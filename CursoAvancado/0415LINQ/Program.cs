using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0415LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 4, 6, 1, 2, 7, 3, 5, 8, 9 };
            IEnumerable<int> retorno1 = lista.Where(p => p >= 4).OrderBy(a => a);
            IEnumerable<int> retorno2 = lista.Where(p => p <= 4).Select(a=>a);
            IEnumerable<int> retorno3 = from a in lista where a > 5 orderby a descending select a;

            List<Usuario> listaUsuario = new List<Usuario>();
            listaUsuario.Add(new Usuario { Id = 1, Nome = "Maria", Email = "maria@gmail.com" });
            listaUsuario.Add(new Usuario { Id = 2, Nome = "João", Email = "joao@msn.com" });
            listaUsuario.Add(new Usuario { Id = 3, Nome = "Felipe", Email = "felipe@gmail.com" });
            listaUsuario.Add(new Usuario { Id = 4, Nome = "Carlos", Email = "carlos@hotmail.com" });
            listaUsuario.Add(new Usuario { Id = 5, Nome = "Amanda", Email = "amanda@gmail.com" });

            List<Acessos> listaAcessos = new List<Acessos>();
            listaAcessos.Add(new Acessos { UsuarioId = 1, DiaAcesso = new DateTime(2018, 01, 02) });
            listaAcessos.Add(new Acessos { UsuarioId = 2, DiaAcesso = new DateTime(2017, 11, 12) });
            listaAcessos.Add(new Acessos { UsuarioId = 1, DiaAcesso = new DateTime(2017, 11, 12) });
            listaAcessos.Add(new Acessos { UsuarioId = 3, DiaAcesso = new DateTime(2017, 12, 14) });

            List<string> retornoListausuario = listaUsuario.Where(a => a.Email.Contains("gmail")).OrderBy(a => a.Nome).Select(a=>a.Nome).ToList();

            var joinUsuarioAcessos = from lu in listaUsuario join la in listaAcessos on lu.Id equals la.UsuarioId where la.DiaAcesso > new DateTime(2018, 1, 1) select new { la.DiaAcesso, lu.Nome };

            var joinUsuarioAcessos2 = from lu in listaUsuario
                                      join la in listaAcessos on lu.Id equals la.UsuarioId
                                      group la by la.UsuarioId into g
                                      select new { Acesso = g.Select(a=>a.DiaAcesso), Qtd = g.Count() };

            Console.ReadKey();
        }
    }
}
