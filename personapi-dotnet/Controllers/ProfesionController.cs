using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Interfaces;

namespace personapi_dotnet.Controllers
{
    public class ProfesionController : Controller
    {
        private readonly IProfesionRepository _profesionRepository;

        public ProfesionController(IProfesionRepository profesionRepository)
        {
            _profesionRepository = profesionRepository;
        }

        public IActionResult Index()
        {
            var profesiones = _profesionRepository.GetAll();
            return View(profesiones);
        }
    }
}