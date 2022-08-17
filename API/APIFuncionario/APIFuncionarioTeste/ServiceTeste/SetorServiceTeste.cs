using APIFuncionario.IRepository;
using APIFuncionario.IService;
using APIFuncionario.Models;
using APIFuncionario.Response;
using APIFuncionario.Service;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionarioTeste.ServiceTeste
{
    public class SetorServiceTeste
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConsultarSetores_RetornaResultado_IsTrue()
        {
            // arrange
            var mock = new Mock<ISetorService>();
            IEnumerable<Setor> setorList = new List<Setor>() 
            {
                new Setor() { Id = 1, Descricao = "setor" }
            };            
            mock.Setup(m => m.ConsultarSetoresRepository()).ReturnsAsync(setorList);
            var responseObject = new ResponseObject<Setor>();
            mock.Setup(m => m.ConsultarSetores()).ReturnsAsync(responseObject);            
            // act
            var setoresRepository = mock.Object.ConsultarSetoresRepository();
            var setoresResponseObject = mock.Object.ConsultarSetores();
            // assert
            Assert.NotNull(setoresRepository);
            Assert.NotNull(setoresResponseObject);
        }
    }
}
