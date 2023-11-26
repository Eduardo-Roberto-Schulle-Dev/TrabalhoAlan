using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            ViewBag.Tarefas = new List<Pizza>
            {
                new Pizza { Nome = "Preparar", Descricao = "A massa", IsSelected = false },
                new Pizza { Nome = "Colocar", Descricao = "O Recheio", IsSelected = false },
                new Pizza { Nome = "Assar ", Descricao = "A Pizza", IsSelected = false }
            };

            return View(ViewBag);
        }
    }
}