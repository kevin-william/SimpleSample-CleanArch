using Sample.Infra.Data.Contexts;
using Sample.Infra.Data.Entities;
using Sample.Infra.Data.Repositories.Interfaces;
using Sample.Infra.Data.UnitOfWork.Interfaces;
using System;

namespace Sample.Infra.Data.UnitOfWork.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private OracleSampleContext Context { get; }
        public IBaseRepository<PessoaEntity> PessoaRepository { get; }

        public UnitOfWork(IBaseRepository<PessoaEntity> pessoaRepository, OracleSampleContext context)
        {
            PessoaRepository = pessoaRepository
                ?? throw new ArgumentNullException(nameof(pessoaRepository));
            Context = context
                ?? throw new ArgumentNullException(nameof(context));
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
