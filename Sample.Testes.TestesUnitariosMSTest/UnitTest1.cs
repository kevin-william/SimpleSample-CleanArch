using Moq;
using Sample.Infra.Data.Entities;
using Sample.Infra.Data.Repositories.Interfaces;
using Sample.Infra.Data.UnitOfWork.Interfaces;

namespace Sample.Testes.TestesUnitariosMSTest
{
    [TestClass]
    public class UnitTest1: IUnitOfWork
    {
        public Mock<IBaseRepository<PessoaEntity>> PessoaRepositoryMock;

        public IBaseRepository<PessoaEntity> PessoaRepository => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
        private void Setup()
        {
            PessoaRepositoryMock = new Mock<IBaseRepository<PessoaEntity>>();
            PessoaRepositoryMock.Setup(obj => obj.Insert(It.IsAny<PessoaEntity>()))
                .Callback((PessoaEntity pessoaEntity) => { });
            PessoaRepositoryMock.Setup(obj => obj.Update(It.IsAny<PessoaEntity>()))
                .Callback((PessoaEntity pessoaEntity) => { });
            PessoaRepositoryMock.Setup(obj => obj.Delete(It.IsAny<PessoaEntity>()))
                .Callback((PessoaEntity pessoaEntity) => { });
            //PessoaRepositoryMock.Setup(obj => obj.Get(It.IsAny<PessoaEntity>()))
            //    .Callback((PessoaEntity pessoaEntity) => { });
        }
    }
}