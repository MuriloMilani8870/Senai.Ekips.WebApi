using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Ekips.WebApi.Domains;
using Senai.Ekips.WebApi.Repositories;

namespace Senai.Ekips.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {


        DepartamentoRepository DepartamentoRepository = new DepartamentoRepository();

        [HttpGet]
        public IEnumerable<Departamentos> Listar()
        {

            // return estilos;
            return DepartamentoRepository.Listar();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Departamentos Departamento = DepartamentoRepository.BuscarPorId(id);
            if (Departamento == null)
            {
                return NotFound();
            }
            return Ok(Departamento);
        }

        [HttpPost]
        public IActionResult Cadastrar(Departamentos Departamentos)
        {
            DepartamentoRepository.Cadastrar(Departamentos);
            return Ok();
        }

    }
}