using System.ComponentModel.DataAnnotations;

namespace DattingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get; set;}
        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="Tu debes e especificar una contraseña entre 4 y 8 caracteres.")]
        public string Password {get; set;}
    }
}