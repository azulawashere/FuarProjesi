using System.ComponentModel.DataAnnotations;

namespace FuarProjesi.Models.Register.RequestModels
{
    public class RegisterRequestModel
    {
        [MinLength(5,ErrorMessage ="Min {1} karakter giriniz")]
        [MaxLength(15, ErrorMessage = "Max {1} karakter giriniz")]
        [Required(ErrorMessage ="Bu Alan Zorunludur")]
        public string UserName { get; set; }

        [MinLength(5, ErrorMessage = "Min {1} karakter giriniz")]
        [MaxLength(15, ErrorMessage = "Max {1} karakter giriniz")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
