using System.Collections.Generic;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario u) {
            UsuarioService usuarioService = new UsuarioService();
            usuarioService.Inserir(u);
            return RedirectToAction("Listagem");
        }

        [HttpGet]
        public IActionResult Edicao(int Id) {
            Autenticacao.CheckLogin(this);
            UsuarioService usuarioService = new UsuarioService();
            Usuario usu = new Usuario();
            usu = usuarioService.ObterPorId(Id);
            return View(usu);
        }

        [HttpPost]
        public IActionResult Edicao(Usuario u) {
            using(BibliotecaContext bc = new BibliotecaContext()) {
                Usuario usu = bc.Usuario.Find(u.Id);
                usu.Login = u.Login;
                usu.Senha = u.Senha;

                bc.SaveChanges();

                return RedirectToAction("Listagem");
            }
        }

        public IActionResult Listagem() {
            Autenticacao.CheckLogin(this);
            ICollection<Usuario> usuarios;
            UsuarioService usuarioService = new UsuarioService();
            usuarios = usuarioService.Listar();
            return View(usuarios);
        }

        public IActionResult Remover(int Id) {
            Autenticacao.CheckLogin(this);
            Usuario usu = new Usuario();
            UsuarioService usuarioService = new UsuarioService();
            usu = usuarioService.ObterPorId(Id);
            usuarioService.Remover(usu);

            return RedirectToAction("Listagem");
        }


    }
}