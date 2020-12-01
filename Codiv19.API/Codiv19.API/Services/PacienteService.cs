using Codiv19.API.Models;
using Codiv19.API.Repositories;
using Codiv19.API.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codiv19.API.Services
{
    public class PacienteService : IPacienteService
    {
        private IPaciente _pacienteRepository;

        public PacienteService()
        {
        }

        public PacienteService(IPaciente pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public Paciente BuscarCPF(string CPF)
        {
            return _pacienteRepository.buscarPorCPF(CPF);
        }

        public Paciente BuscarID(int id)
        {
            return _pacienteRepository.buscaPorId(id);         
        }

        public IList<Paciente> BuscaTodosPacientes()
        {
            return _pacienteRepository.buscaTodosPacientes();
        }

        public int NovoPaciente(Paciente paciente)
        {
            var validator = new PacienteValidator();
            var validRes = validator.Validate(paciente);
            if (validRes.IsValid)
            {
                return _pacienteRepository.novoPaciente(paciente);
            }
            else
                throw new Exception(validRes.Errors.FirstOrDefault().ToString());
               
                
        }
    }
}
