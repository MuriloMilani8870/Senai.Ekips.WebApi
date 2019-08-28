using Senai.Ekips.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Ekips.WebApi.Repositories
{
    public class CargoRepository
    {
        /// <summary>
        /// Listas todos os cargos
        /// </summary>
        /// <returns>Lista de cargos</returns>
        public List<Cargos> Listar()
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                return ctx.Cargos.ToList();
            }
        }

        /// <summary>
        /// Cadastra um cargo
        /// </summary>
        /// <param name="cargo"></param>

        public void Cadastrar(Cargos cargo)
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                ctx.Cargos.Add(cargo);
                ctx.SaveChanges();
            }
        }
        /// <summary>
        /// Busca um Cargo através do ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Cargo Buscado</returns>

        public Cargos BuscarPorId(int id)
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                return ctx.Cargos.FirstOrDefault(x => x.IdCargo == id);
            }
        }

        /// <summary>
        /// Atualiza um cargo
        /// </summary>
        /// <param name="cargo"></param>
        
        public void Atualizar(Cargos cargo)
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                Cargos cargoBuscado = ctx.Cargos.FirstOrDefault(x => x.IdCargo == cargo.IdCargo);
                cargoBuscado.NomeCargo = cargo.NomeCargo;
                cargoBuscado.Ativo = cargo.Ativo;
                ctx.Cargos.Update(cargoBuscado);
                ctx.SaveChanges();
            }
        }
    }
}
