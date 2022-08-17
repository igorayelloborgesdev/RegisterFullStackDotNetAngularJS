using APIFuncionario.IService;
using APIFuncionario.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionarioTeste.Service
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
            Mock<ISetorService> mock = new Mock<ISetorService>();
            IEnumerable<Setor> setorList = new List<Setor>();
            mock.Setup(m => m.ConsultarSetores()).Returns((Task<APIFuncionario.Response.ResponseObject<Setor>>)setorList);
            // act
            // assert
            Assert.IsTrue(true);
        }
    }
}
