using Codiv19.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codiv19.API.Services
{
    public interface IPacienteService
    {
        public Paciente BuscarID(int id);
        public Paciente BuscarCPF(string CPF);
        public IList<Paciente> BuscaTodosPacientes();
        public int NovoPaciente(Paciente paciente);

    }
}
