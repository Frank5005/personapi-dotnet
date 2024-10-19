using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Interfaces;

namespace personapi_dotnet.Controllers
{
    public class EstudiosController : Controller
    {
        private readonly IEstudiosRepository _estudiosRepository;

        public EstudiosController(IEstudiosRepository estudiosRepository)
        {
            _estudiosRepository = estudiosRepository;
        }

        public IActionResult Index()
        {
            var estudios = _estudiosRepository.GetAll();
            return View(estudios);
        }
    }
}