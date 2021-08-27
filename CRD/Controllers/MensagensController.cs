using AutoMapper;
using CRD.Data;
using CRD.Data.Dtos;
using CRD.Models;
using Google.GData.Extensions;
using MensagensAPI.Data.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class MensagemController : ControllerBase
    {

        private MensagensContext _context;
        private IMapper _mapper;
        private Usuario_mensagemContext _context2;

        public MensagemController(MensagensContext context, Usuario_mensagemContext context2, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _context2 = context2;
        }

        //-------------------------------------------------------------------

        [HttpPost("PostMensa")]
        public IActionResult AdicionarMensagem([FromBody] CreateMensagemDto mensagemDto)
        {
            Mensagem mensagem = _mapper.Map<Mensagem>(mensagemDto);
            
            _context.Mensagens.Add(mensagem);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaMensagensPorId), new { Id = mensagem.Id }, mensagem);
        }

        //-------------------------------------------------------------------

        [HttpGet]
        public IActionResult RecuperarMensagens()
        {
            return Ok(_context.Mensagens);
        }

        //-------------------------------------------------------------------

        [HttpGet("GetByIdM/{id}")]
        public IActionResult RecuperaMensagensPorId(int id)
        {
            Mensagem mensagem = _context.Mensagens.FirstOrDefault(mensagem => mensagem.Id == id);
            if(mensagem != null)
            {
                ReadMensagemDto mensagemDto = _mapper.Map<ReadMensagemDto>(mensagem);

                return Ok(mensagem);
            }
            return NotFound();
        }
        
        //-------------------------------------------------------------------


        //-------------------------------------------------------------------

        [HttpPut("{id}")]
        public IActionResult AtualizaMensagem(int id, [FromBody] UpdateMensagemDto mensagemDto)
        {
            Mensagem mensagem = _context.Mensagens.FirstOrDefault(mensagem => mensagem.Id == id);
            if(mensagem == null)
            {
                return NotFound();
            }
            _mapper.Map(mensagemDto, mensagem);
            _context.SaveChanges();
            return NoContent();


        }

        //-------------------------------------------------------------------


        [HttpPost("Usu+Mensa")]
        public IActionResult Adicionarusuario_mensagem([FromBody] Createusuario_mensagemDto usuario_mensagemDto)
        {
            Usuario_mensagem usuario_mensagem = _mapper.Map<Usuario_mensagem>(usuario_mensagemDto);
            
            _context2.Usuario_mensagem.Add(usuario_mensagem);
            _context2.SaveChanges();
            return CreatedAtAction(nameof(Recuperausuario_mensagemPorId), new { Id = usuario_mensagem.Id }, usuario_mensagem);
        }

        //-------------------------------------------------------------------

        [HttpGet("Usu+MensaId{id}")]
        public IActionResult Recuperausuario_mensagemPorId(int id)
        {
            Usuario_mensagem usuario_mensagem = _context2.Usuario_mensagem.FirstOrDefault(usuario_mensagem => usuario_mensagem.Id == id);
            if (usuario_mensagem != null)
            {
                Readusuario_mensagemDto usuario_mensagemDto = _mapper.Map<Readusuario_mensagemDto>(usuario_mensagem);

                return Ok(usuario_mensagem);
            }
            return NotFound();
        }

        //----------------------------------------------------------

/*essa parte aqui é a que eu n consegui, era pra trazer todas aas mensagens que o IdUsuario ja leu mas traz só a ultima, imagino
Que seja por causa do "FirstOrDefault" e eu n consegui fazer o where funcionar.*/

[HttpGet("Usu+MensaId/usuario/{IdUsuario}")]
public IActionResult RecuperausuarioEmensagemPorId(int IdUsuario)
{
    Usuario_mensagem usuario_mensagem = _context2.Usuario_mensagem.FirstOrDefault(usuario_mensagem => usuario_mensagem.IdUsuario == IdUsuario);
    if (usuario_mensagem.IdUsuario != null)
    {
        Readusuario_mensagemDto usuario_mensagemDto = _mapper.Map<Readusuario_mensagemDto>(usuario_mensagem);

        return Ok(usuario_mensagem);
    }
    return NotFound();
}

//----------------------------------------------------------


}
}
