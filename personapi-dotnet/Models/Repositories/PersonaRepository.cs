using personapi_dotnet.Models.Entities;
using personapi_dotnet.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace personapi_dotnet.Models.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly PersonaDbContext _context;

        public PersonaRepository(PersonaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Persona> GetAll() => _context.Persona.ToList();

        public Persona GetById(int cc) => _context.Persona.Find(cc);

        public void Add(Persona persona)
        {
            _context.Persona.Add(persona);
            _context.SaveChanges();
        }

        public void Update(Persona persona)
        {
            _context.Persona.Update(persona);
            _context.SaveChanges();
        }

        public void Delete(int cc)
        {
            var persona = _context.Persona.Find(cc);
            if (persona != null)
            {
                _context.Persona.Remove(persona);
                _context.SaveChanges();
            }
        }
    }
}