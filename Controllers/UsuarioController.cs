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

        public IActionResult Edicao() {
            return View();
        }

        public IActionResult Listagem() {
            ICollection<Usuario> usuarios;
            UsuarioService usuarioService = new UsuarioService();
            usuarios = usuarioService.Listar();
            return View(usuarios);
        }


    }
}