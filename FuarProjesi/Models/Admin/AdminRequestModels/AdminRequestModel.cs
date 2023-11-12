using System.ComponentModel.DataAnnotations;

namespace FuarProjesi.Models.Admin.AdminRequestModels
{
    public class AdminRequestModel
    {
        [Required(ErrorMessage = "Zorunludur")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Zorunludur")]
        public string Password { get; set; }


    }
}
