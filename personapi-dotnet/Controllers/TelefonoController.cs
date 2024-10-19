using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Interfaces;

namespace personapi_dotnet.Controllers
{
    public class TelefonoController : Controller
    {
        private readonly ITelefonoRepository _telefonoRepository;

        public TelefonoController(ITelefonoRepository telefonoRepository)
        {
            _telefonoRepository = telefonoRepository;
        }

        public IActionResult Index()
        {
            var telefonos = _telefonoRepository.GetAll();
            return View(telefonos);
        }
    }
}