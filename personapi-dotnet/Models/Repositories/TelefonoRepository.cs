using personapi_dotnet.Models.Entities;
using personapi_dotnet.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace personapi_dotnet.Models.Repositories
{
    public class TelefonoRepository : ITelefonoRepository
    {
        private readonly PersonaDbContext _context;

        public TelefonoRepository(PersonaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Telefono> GetAll() => _context.Telefono.ToList();

        public Telefono GetById(string num) => _context.Telefono.Find(num);

        public void Add(Telefono telefono)
        {
            _context.Telefono.Add(telefono);
            _context.SaveChanges();
        }

        public void Update(Telefono telefono)
        {
            _context.Telefono.Update(telefono);
            _context.SaveChanges();
        }

        public void Delete(string num)
        {
            var telefono = _context.Telefono.Find(num);
            if (telefono != null)
            {
                _context.Telefono.Remove(telefono);
                _context.SaveChanges();
            }
        }
    }
}