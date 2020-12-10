using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Auditing;
using Volo.Abp.Identity;
using Volo.Abp.Validation;

namespace EasyAbp.Abp.PhoneNumberLogin.Web.Controllers.PhoneNumberLogin.Account.Dtos
{
    [Serializable]
    public class LoginByPasswordInput
    {
        [Required]
        [DynamicStringLength(typeof(IdentityUserConsts), nameof(IdentityUserConsts.MaxPhoneNumberLength))]
        public string PhoneNumber { get; set; }
        
        [Required]
        [DynamicStringLength(typeof(IdentityUserConsts), nameof(IdentityUserConsts.MaxPhoneNumberLength))]
        [DisableAuditing]
        public string Password { get; set; }
        
        public bool RememberMe { get; set; }
    }
}