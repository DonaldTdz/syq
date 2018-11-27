

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HC.WeChat.Contacts;

namespace HC.WeChat.Contacts.Dtos
{
    public class CreateOrUpdateContactInput
    {
        [Required]
        public ContactEditDto Contact { get; set; }

    }
}