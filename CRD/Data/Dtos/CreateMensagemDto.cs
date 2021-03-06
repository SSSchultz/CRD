using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MensagensAPI.Data.Dtos
{
    public class CreateMensagemDto
    {
        [Required(ErrorMessage = "Especifique o tipo de usuario alvo.")]
        public string TipoDeUsuario { get; set; }

        [Required(ErrorMessage = "O titulo da mensagem é necessario.")]
        public string TituloDoComunicado { get; set; }

        [Required(ErrorMessage = "Escreva a mensagem.")]
        public string TextoDoComunicado { get; set; }
    }
}
