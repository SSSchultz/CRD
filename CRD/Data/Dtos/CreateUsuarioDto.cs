using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Data.Dtos
{
    public class CreateUsuarioDto
    {
        [Required(ErrorMessage = "Especifique o tipo de usuario alvo.")]
        public string TipoDeUsuario { get; set; }

        [Required(ErrorMessage = "O Local do Usuario é necessario.")]
        public string LocalDoUsuario { get; set; }

        [Required(ErrorMessage = "Adicione o nome do Usuario")]
        public string NomeDoUsuario { get; set; }
    }
}
