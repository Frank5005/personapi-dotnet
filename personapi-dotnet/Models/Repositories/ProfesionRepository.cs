using personapi_dotnet.Models.Entities;
using personapi_dotnet.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace personapi_dotnet.Models.Repositories
{
    public class ProfesionRepository : IProfesionRepository
    {
        private readonly PersonaDbContext _context;

        public ProfesionRepository(PersonaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Profesion> GetAll() => _context.Profesion.ToList();

        public Profesion GetById(int id) => _context.Profesion.Find(id);

        public void Add(Profesion profesion)
        {
            _context.Profesion.Add(profesion);
            _context.SaveChanges();
        }

        public void Update(Profesion profesion)
        {
            _context.Profesion.Update(profesion);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var profesion = _context.Profesion.Find(id);
            if (profesion != null)
            {
                _context.Profesion.Remove(profesion);
                _context.SaveChanges();
            }
        }
    }
}