using Codiv19.API.Models;
using Codiv19.API.Services;
using NUnit.Framework;
using System;

namespace Covid.Teste
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCPFInvalido()
        {
            Paciente paciente = new Paciente();
            paciente.id = 1;
            paciente.nome = "Jean";
            paciente.idade = 37;
            paciente.sexo = "Masculino";
            paciente.uf = "MG";
            paciente.estado = "Minas Gerais";
            paciente.estadoCivil = "casado";
            paciente.flComorbidade = false;
            paciente.dataRegistro = DateTime.Now;
            paciente.cpf = "00000000000";
            paciente.cidade = "Araxa";
            PacienteService _service = new PacienteService();
            var ex = Assert.Throws<Exception>(() => _service.NovoPaciente(paciente));
            Assert.That(ex.Message, Is.EqualTo("Cpf é inválido"));
        }
    }
}