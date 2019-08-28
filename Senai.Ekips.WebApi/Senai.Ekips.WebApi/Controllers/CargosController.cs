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
    [ApiController]
    public class CargosController : ControllerBase
    {

        CargosRepository CargosRepository = new CargosRepository();

        [HttpGet]
        public IEnumerable<Cargos> Listar()
        {

            // return estilos;
            return CargosRepository.Listar();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Cargos Funcionario = CargosRepository.BuscarPorId(id);
            if (Funcionario == null)
            {
                return NotFound();
            }
            return Ok(Funcionario);
        }

        [HttpPost]
        public IActionResult Cadastrar(Cargos Cargos)
        {
            CargosRepository.Cadastrar(Cargos);
            return Ok();
        }

        [HttpPut("{id}")]

        public IActionResult Atualizar(Cargos Cargos, int id)
        {
            Cargos.IdCargo = id;
            CargosRepository.Atualizar(Cargos);
            return Ok();
        }
    }
}