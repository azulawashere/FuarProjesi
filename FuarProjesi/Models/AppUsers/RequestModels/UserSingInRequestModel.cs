using System.ComponentModel.DataAnnotations;

namespace FuarProjesi.Models.AppUsers.RequestModels
{
    public class UserSingInRequestModel
    {

        [Required(ErrorMessage = "Kullanıcı ismi zorunludur")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Sifre alanı zorunludur")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
