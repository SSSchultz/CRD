using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Especifique o tipo de usuario alvo.")]
        public string TipoDeUsuario { get; set; }

        [Required(ErrorMessage = "O titulo da mensagem é necessario.")]
        public string LocalDoUsuario { get; set; }

        [Required(ErrorMessage = "Escreva a mensagem.")]
        public string NomeDoUsuario { get; set; }
    }
}
