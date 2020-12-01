using Codiv19.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codiv19.API.Repositories
{
    public interface IPaciente
    {
        public Paciente buscaPorId(int id);
        public Paciente buscarPorCPF(string CPF);
        public IList<Paciente> buscaTodosPacientes();
        public int novoPaciente(Paciente paciente);
    }
}
