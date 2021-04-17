using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        public void Inserir(Usuario u) {
            using(BibliotecaContext bc = new BibliotecaContext()) 
            {
                bc.Usuario.Add(u);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Usuario u)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario usuario = bc.Usuario.Find(u.Id);
                usuario.Nome = u.Nome;
                usuario.Login = u.Login;
                usuario.Senha = u.Senha;

                bc.SaveChanges();
            }
        }

        public ICollection<Usuario> Listar() 
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                IQueryable<Usuario> query;

                query = bc.Usuario;

                return query.OrderBy(u => u.Id).ToList();
            }

        }

        public void Remover(Usuario u) 
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuario.Remove(u);
                bc.SaveChanges();
            }
        }

        public Usuario ObterPorId(int Id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuario.Find(Id);
            }
        }
    }
}