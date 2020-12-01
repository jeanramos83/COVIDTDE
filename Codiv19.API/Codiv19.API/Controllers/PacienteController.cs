using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Codiv19.API.Models;
using Codiv19.API.Repositories;
using Codiv19.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codiv19.API.Controllers
{
    [Authorize(Roles = "administrador")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private IPacienteService _service;

        public PacienteController(IPacienteService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _service.BuscaTodosPacientes();
            return Ok("Litagem de todos os pacientes");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            _service.BuscarID(id);
            return Ok("dados do paciente id");
        }
        [HttpGet("{cpf}")]
        public async Task<IActionResult> Get(string cpf)
        {
            _service.BuscarCPF(cpf);
            return Ok("dados do paciente cpf");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Paciente paciente)
        {
            _service.NovoPaciente(paciente);
            return Ok("Paciente cadastrado com sucesso");
        }

        [HttpPut]
        public async Task<IActionResult> Put(Paciente paciente)
        {
            Paciente p = new Paciente();

            return Ok("Paciente atualizado com sucesso");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int  id)
        {
            return Ok("Paciente deleteado com sucesso");
        }

    }
}
