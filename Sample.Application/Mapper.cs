using AutoMapper;
using Sample.Domain.Models;
using Sample.Infra.Data.Entities;

namespace Sample.Application
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Pessoa, PessoaEntity>().ReverseMap();
        }
    }
}
