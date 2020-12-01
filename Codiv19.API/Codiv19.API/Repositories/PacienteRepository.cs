using Codiv19.API.Context;
using Codiv19.API.Models;
using Codiv19.API.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codiv19.API.Repositories
{
    public class PacienteRepository : IPaciente
    {
        private COVIDContext _context;

        public PacienteRepository(COVIDContext context)
        {
            _context = context;
        }

        public Paciente buscaPorId(int id)
        {
            return _context.paciente.ToList().Where(y => y.id == id).FirstOrDefault();
        }

        public Paciente buscarPorCPF(string CPF)
        {
            return _context.paciente.ToList().Where(y => y.cpf == CPF).FirstOrDefault();
        }
        
        public IList<Paciente> buscaTodosPacientes()
        {
            return _context.paciente.ToList();
        }

        public int novoPaciente(Paciente paciente)
        {
            _context.paciente.Add(paciente);
            _context.SaveChanges();
            return paciente.id;
        }
    }
    
}
