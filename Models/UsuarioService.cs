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
                bc.Usuarios.Add(u);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Usuario u)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario usuario = bc.Usuarios.Find(u.Id);
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

                query = bc.Usuarios;

                return query.OrderBy(u => u.Id).ToList();
            }

        }

        public void Remover(Usuario u) 
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Remove(u);
                bc.SaveChanges();
            }
        }
    }
}