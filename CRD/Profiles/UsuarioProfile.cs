using AutoMapper;
using CRD.Data.Dtos;
using CRD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<Usuario, ReadUsuarioDto>();
            CreateMap<updateUsuarioDto, Usuario>();
        }
    }
}
