using AutoMapper;
using CRD.Data;
using CRD.Data.Dtos;
using CRD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class UsuariosController : ControllerBase
    {

        private UsuariosContext _context;
        private IMapper _mapper;

        public UsuariosController(UsuariosContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarUsuario([FromBody] CreateUsuarioDto usuarioDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDto);

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaUsuariosPorId), new { Id = usuario.Id }, usuario);
        }

        [HttpGet]
        public IEnumerable<Usuario> RecuperaUsuarios()
        {
            return _context.Usuarios;
        }


        [HttpGet("{id}")]
        public IActionResult RecuperaUsuariosPorId(int id)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario != null)
            {
                ReadUsuarioDto usuarioDto = _mapper.Map<ReadUsuarioDto>(usuario);

                return Ok(usuario);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaUsuario(int id, [FromBody] updateUsuarioDto usuarioDto)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if(usuario == null)
            {
                return NotFound();
            }
            _mapper.Map(usuarioDto, usuario);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaUsuario(int id)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            _context.Remove(usuario);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
