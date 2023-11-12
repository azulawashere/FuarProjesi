using System.ComponentModel.DataAnnotations;

namespace FuarProjesi.Models.LogIn.RequestModels
{
    public class LogInRequestModel
    {
        [Required(ErrorMessage ="{0} is required!")]
        [MinLength(5, ErrorMessage = "Min {1} karakter giriniz")]
        [MaxLength(15, ErrorMessage = "Max {1} karakter giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [MinLength(5, ErrorMessage = "Min {1} karakter giriniz")]
        [MaxLength(15, ErrorMessage = "Max {1} karakter giriniz")]
        public string Password { get; set; }
    }
}
