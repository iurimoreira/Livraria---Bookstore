using Livraria.Models.Clientes;
using Livraria.Models.Domain;
using Livraria.Models.ViewModel;
using System.Web.Mvc;

namespace Livraria.Controllers.Web
{
    public class AutoresController : Controller
    {
        private AutorCliente AC = new AutorCliente();

        public ActionResult Index()
        {
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
            AC.Criar(autor);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            AC.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            AutorViewModel autor = new AutorViewModel();
            autor = AC.encontrar(id);
            return View("Editar", autor);
        }
        [HttpPost]
        public ActionResult Editar(Autor autor)
        {
            AC.Editar(autor);
            return RedirectToAction("Index");
        }
    }
}