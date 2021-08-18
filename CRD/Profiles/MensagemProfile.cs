using AutoMapper;
using CRD.Models;
using MensagensAPI.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Profiles
{
    public class MensagemProfile : Profile
    {
        public MensagemProfile()
        {
            CreateMap<CreateMensagemDto, Mensagem>();
            CreateMap<Mensagem, ReadMensagemDto>();
            CreateMap<UpdateMensagemDto, Mensagem>();
        }
    }
}
