using System.ComponentModel.DataAnnotations;

namespace FuarProjesi.Models.LogIn.RequestModels
{
    public class LogInRequestModel
    {
        [Required(ErrorMessage ="{0} is required!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        public string Password { get; set; }
    }
}
