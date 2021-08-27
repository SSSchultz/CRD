using AutoMapper;
using CRD.Data.Dtos;
using CRD.Models;
using MensagensAPI.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Profiles
{
    public class Usuario_mensagemProfile : Profile
    {
        public Usuario_mensagemProfile()
        {
            CreateMap<Createusuario_mensagemDto, Usuario_mensagem>();
            CreateMap<Usuario_mensagem, Readusuario_mensagemDto>();
        }
    }
}
