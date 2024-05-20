using System.ComponentModel.DataAnnotations;

namespace UsuariosApp.API.DTOs.Requests
{
    public class AutenticarUsuarioRequestDTO
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o e-mail do usúario")]
        public string? Email { get; set; }

        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a senha do usúario")]
        public string? Senha { get; set; }
    }
}
