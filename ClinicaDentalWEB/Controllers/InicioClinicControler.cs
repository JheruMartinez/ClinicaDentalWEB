using Microsoft.AspNetCore.Mvc;

namespace ClinicaDentalWEB.Controllers
{
    public class InicioClinicControler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
