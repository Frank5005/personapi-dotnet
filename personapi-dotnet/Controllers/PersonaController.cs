using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Interfaces;

namespace personapi_dotnet.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaController(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public IActionResult Index()
        {
            var personas = _personaRepository.GetAll();
            return View(personas);
        }
    }
}