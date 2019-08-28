using Microsoft.EntityFrameworkCore;
using Senai.Ekips.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Ekips.WebApi.Repositories
{
    public class FuncionarioRepository
    {

        //public List<Funcionarios> Listar()
        //{
        //    using (EkipsContext ctx = new EkipsContext())
        //    {
        //        return ctx.Funcionarios.Include(x => x.IdCargoNavigation, ctx.Funcionarios.Include(x => x.IdDepartamentoNavigation, ctx.Funcionarios.Include(x => x.IdUsuarioNavigation))).ToList();
        //    }
        //}

        public void Cadastrar(Funcionarios funcionario)
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                ctx.Funcionarios.Add(funcionario);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                Funcionarios FuncionarioBuscado = ctx.Funcionarios.Find(id);
                ctx.Funcionarios.Remove(FuncionarioBuscado);
                ctx.SaveChanges();
            }
        }
    }
}
