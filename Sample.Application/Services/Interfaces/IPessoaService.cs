using Sample.Domain.Models;
using System.Collections.Generic;

namespace Sample.Application.Services.Interfaces
{
    public interface IPessoaService
    {
        IEnumerable<Pessoa> Get();
        Pessoa GetByID(object id);
        void Insert(Pessoa entity);
        void Delete(object id);
        void Delete(Pessoa entityToDelete);
        void Update(Pessoa entityToUpdate);
    }
}
