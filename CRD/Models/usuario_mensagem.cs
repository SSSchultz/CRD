using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Models
{
    public class Usuario_mensagem
    {

        

        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Falta o ID do Usuario.")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Falta o ID da mensagem.")]
        public int IdMensagem { get; set; }

    }
}
