using System.Web.Mvc;
using Livraria.Models.Domain;
using Livraria.Models.Clientes;
using Livraria.Models.ViewModel;

namespace Livraria.Controllers.Web
{
    public class LivrosController : Controller
    {
        public ActionResult Index()
        {
            LivroCliente LC = new LivroCliente();
            ViewBag.listBooks = LC.pegarTodos();

            return View();
        }
        [HttpGet]
        public ActionResult Criar()
        {
            return View("Criar");
        }
        [HttpPost]
        public ActionResult Criar(LivroViewModel livro)
        {
            LivroCliente LC = new LivroCliente();
            LC.Criar(livro);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            LivroCliente LC = new LivroCliente();
            LC.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            LivroCliente LC = new LivroCliente();
            Livro livro = new Livro();
            livro = LC.encontrar(id);
            return View("Editar", livro);
        }
        [HttpPost]
        public ActionResult Editar(Livro livro)
        {
            LivroCliente LC = new LivroCliente();
            LC.Editar(livro);
            return RedirectToAction("Index");
        }
    }
}
