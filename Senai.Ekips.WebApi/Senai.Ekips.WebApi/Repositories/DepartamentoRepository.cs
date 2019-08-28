using Senai.Ekips.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Ekips.WebApi.Repositories
{
    public class DepartamentoRepository
    {
        /// <summary>
        /// Listas todos os Departamentos
        /// </summary>
        /// <returns>Lista de Departamentos</returns>
        public List<Departamentos> Listar()
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                return ctx.Departamentos.ToList();
            }
        }

        /// <summary>
        /// Cadastra um departamento
        /// </summary>
        /// <param name="departamento"></param>

        public void Cadastrar(Departamentos departamento)
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                ctx.Departamentos.Add(departamento);
                ctx.SaveChanges();
            }
        }
        /// <summary>
        /// Busca um departamento através do ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>departamento Buscado</returns>

        public Departamentos BuscarPorId(int id)
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                return ctx.Departamentos.FirstOrDefault(x => x.IdDepartamento == id);
            }
        }
    }
}
