using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Data.Dtos
{
    public class Readusuario_mensagemDto
    {
        [Required(ErrorMessage = "Falta o ID do Usuario.")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Falta o ID da mensagem.")]
        public int IdMensagem { get; set; }

    }
}
