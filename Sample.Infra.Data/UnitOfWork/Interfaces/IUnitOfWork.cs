using Sample.Infra.Data.Entities;
using Sample.Infra.Data.Repositories.Interfaces;
using System;

namespace Sample.Infra.Data.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<PessoaEntity> PessoaRepository { get; }
        void Save();
    }
}
