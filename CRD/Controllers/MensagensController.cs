using AutoMapper;
using CRD.Data;
using CRD.Models;
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

            public MensagemController(MensagensContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarMensagem([FromBody] CreateMensagemDto mensagemDto)
        {
            Mensagem mensagem = _mapper.Map<Mensagem>(mensagemDto);
            
            _context.Mensagens.Add(mensagem);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaMensagensPorId), new { Id = mensagem.Id }, mensagem);
        }

        [HttpGet]
        public IActionResult RecuperarMensagens()
        {
            return Ok(_context.Mensagens);
        }

        [HttpGet("{id}")]
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
    }
}
