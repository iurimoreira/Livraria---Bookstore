using Livraria.Models.Clientes;
using Livraria.Models.Domain;
using Livraria.Models.ViewModel;
using System.Web.Mvc;

namespace Livraria.Controllers.Web
{
    public class AutoresController : Controller
    {
        public ActionResult Index()
        {
            AutorCliente AC = new AutorCliente();
            ViewBag.listBooks = AC.pegarTodos();

            return View();
        }
        [HttpGet]
        public ActionResult Criar()
        {
            return View("Criar");
        }
        [HttpPost]
        public ActionResult Criar(AutorViewModel autor)
        {
            AutorCliente AC = new AutorCliente();
            AC.Criar(autor);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            AutorCliente AC = new AutorCliente();
            AC.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            AutorCliente AC = new AutorCliente();
            Autor autor = new Autor();
            autor = AC.encontrar(id);
            return View("Editar", autor);
        }
        [HttpPost]
        public ActionResult Editar(Autor autor)
        {
            AutorCliente AC = new AutorCliente();
            AC.Editar(autor);
            return RedirectToAction("Index");
        }
    }
}