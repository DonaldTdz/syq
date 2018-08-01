using System;
using HC.WeChat.Authorization.WeChatOAuth;
using HC.WeChat.Controllers;
using HC.WeChat.Dto;
using HC.WeChat.WechatAppConfigs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senparc.Weixin.MP.Helpers;
using HC.WeChat.WeChatUsers;
using Abp.Domain.Repositories;
using HC.WeChat.Orders;
using HC.WeChat.Activities;

namespace HC.WeChat.Web.Host.Controllers
{
    public class SYQWXController : WeChatWebControllerBase
    {
        IWeChatOAuthAppService _weChatOAuthAppService;
        IWeChatUserAppService _weChatUserAppService;
        IOrderAppService _orderAppService;
        IActivityAppService _activityAppService;
        //private string host = "http://localhost:21021";
        //private string host = "http://wx.photostory.top";
        private string host = "http://weixinserver.sayequ.me";
        private int? tenantId;

        private string UserOpenId
        {
            get
            {
                if (HttpContext.Session.GetString("SYQUserOpenId") == null)
                {
                    return string.Empty;
                }
                return HttpContext.Session.GetString("SYQUserOpenId");
            }
            set
            {
                value = value ?? string.Empty;
                HttpContext.Session.SetString("SYQUserOpenId", value);
            }
        }

        protected override int? GetTenantId()
        {
            return tenantId;
        }

        public SYQWXController(IWechatAppConfigAppService wechatAppConfigAppService,
          IWeChatOAuthAppService weChatOAuthAppService,
          IWeChatUserAppService weChatUserAppService,
          IOrderAppService orderAppService,
          IActivityAppService activityAppService
            ) : base(wechatAppConfigAppService)
        {
            InitAppConfigSetting();
            _weChatOAuthAppService = weChatOAuthAppService;
            _weChatOAuthAppService.WechatAppConfig = WechatAppConfig;//注入配置
            _weChatUserAppService = weChatUserAppService;
            _orderAppService = orderAppService;
            _activityAppService = activityAppService;
        }

        private void SetUserOpenId(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return;
            }
            //如果userId为null 则需要通过code重新获取
            if (string.IsNullOrEmpty(UserOpenId))
            {
                try
                {
                    var oauth = _weChatOAuthAppService.GetAccessTokenAsync(code).Result;
                    UserOpenId = oauth.openid;
                }
                catch (Exception ex)
                {
                    Logger.ErrorFormat("GetAccessTokenAsync Exception:{0}", ex.Message);
                }
            }
        }

        public IActionResult GetCurrentUserOpenId()
        {
            APIResultDto result = new APIResultDto();
            //UserOpenId = "4f72bb43-704d-4d47-b3c1-4631c90427a2";
            //UserOpenId = "oB4nYjnoHhuWrPVi2pYLuPjnCaU0"; //杨帆专用

            if (string.IsNullOrEmpty(UserOpenId))
            {
                result.Code = 901;
                result.Msg = "用户没有登录";
            }
            else
            {
                result.Code = 0;
                result.Msg = "获取成功";
                result.Data = new { openId = UserOpenId, tenantId = GetTenantId() };
            }
            return Json(result);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SYQIndex(string code, string state)
        {
            //存储openId 避免重复提交
            SetUserOpenId(code);
            //UserOpenId = "4f72bb43-704d-4d47-b3c1-4631c90427a2";
            //oWusewEMAQ_9km_ME19diwMrEop4
            //UserOpenId = "o6HO_whNjkmQS87qbn4_704i82Iw"; 
            var result = _orderAppService.GetWXOrderListByOpenIdAsync(UserOpenId,host).Result;
            
            ViewBag.OrderList = result;
            ViewBag.Count = result.Count;
            return View();
        }

        /// <summary>
        /// 获取JS SDK配置
        /// </summary>
        public IActionResult GetJsApiConfig(string url)
        {
            var jsApiConfig = JSSDKHelper.GetJsSdkUiPackageAsync(WechatAppConfig.AppId, WechatAppConfig.AppSecret, url).Result;
            return Json(jsApiConfig);
        }

        [HttpGet]
        public IActionResult Authorization(SYQAuthorizationPageEnum page, string param)
        {
            var url = string.Empty;
            //UserOpenId = "4f72bb43-704d-4d47-b3c1-4631c90427a2";

            switch (page)
            {
                case SYQAuthorizationPageEnum.OrderCenter:
                    {
                        if (!string.IsNullOrEmpty(UserOpenId))
                        {
                            return RedirectToAction("SYQIndex");
                        }
                        url = host + "/SYQWX/SYQIndex";
                    }
                    break;
                default:
                    {
                        return Redirect("/gawechat/index.html");
                    }
            }

            param = param ?? "123";
            var pageUrl = _weChatOAuthAppService.GetAuthorizeUrl(url, param, Senparc.Weixin.MP.OAuthScope.snsapi_base);
            return Redirect(pageUrl);
            //return View();
        }


        /// <summary>
        /// 订单中心
        /// </summary>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public IActionResult OrderCenter(string code, string state)
        {
            //存储openId 避免重复提交
            SetUserOpenId(code);
            return RedirectToAction("SYQIndex");
        }

        public IActionResult Login(string openId)
        {
            UserOpenId = openId;
            return RedirectToAction("SYQIndex");
        }

        public IActionResult Error(int? statusCode)
        {
            return RedirectToAction("SYQIndex");
        }
    }

    public enum SYQAuthorizationPageEnum
    {
        OrderCenter = 101
    }
}