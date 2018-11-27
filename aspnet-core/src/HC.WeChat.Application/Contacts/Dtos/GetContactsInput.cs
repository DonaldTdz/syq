
using Abp.Runtime.Validation;
using HC.WeChat.Dto;

namespace HC.WeChat.Contacts.Dtos
{
    public class GetContactsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
