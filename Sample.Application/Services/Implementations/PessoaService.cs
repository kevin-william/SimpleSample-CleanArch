using AutoMapper;
using Sample.Application.Services.Interfaces;
using Sample.Domain.Models;
using Sample.Infra.Data.Entities;
using Sample.Infra.Data.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;

namespace Sample.Application.Services.Implementations
{
    public class PessoaService : IPessoaService, IDisposable
    {
        public IUnitOfWork UnitOfWork { get; }
        public IMapper Mapper { get; }

        public PessoaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork
                ?? throw new ArgumentNullException(nameof(unitOfWork));
            Mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        public void Delete(object id)
        {
            UnitOfWork.PessoaRepository.Delete(id);
            UnitOfWork.Save();
        }

        public void Delete(Pessoa entityToDelete)
        {
            UnitOfWork.PessoaRepository.Delete(entityToDelete);
            UnitOfWork.Save();
        }

        public IEnumerable<Pessoa> Get()
        {
            var result = UnitOfWork.PessoaRepository.Get();
            return Mapper.Map<IEnumerable<Pessoa>>(result);
        }

        public Pessoa GetByID(object id)
        {
            var result = UnitOfWork.PessoaRepository.GetByID(id);
            return Mapper.Map<Pessoa>(result);
        }

        public void Insert(Pessoa entity)
        {
            var pessoa = Mapper.Map<PessoaEntity>(entity);
            UnitOfWork.PessoaRepository.Insert(pessoa);
            UnitOfWork.Save();
        }

        public void Update(Pessoa entityToUpdate)
        {
            var pessoa = Mapper.Map<PessoaEntity>(entityToUpdate);
            UnitOfWork.PessoaRepository.Update(pessoa);
            UnitOfWork.Save();
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
    }
}
