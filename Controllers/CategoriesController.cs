using Microsoft.AspNetCore.Mvc;

namespace TP_Gestion_Commandes.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
