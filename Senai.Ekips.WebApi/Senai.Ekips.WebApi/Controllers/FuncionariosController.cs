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
    public class FuncionariosController : ControllerBase
    {
        FuncionarioRepository FuncionarioRepository = new FuncionarioRepository();

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            FuncionarioRepository.Deletar(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult Cadastrar(Funcionarios Funcionarios)
        {
            FuncionarioRepository.Cadastrar(Funcionarios);
            return Ok();
        }

    }
}