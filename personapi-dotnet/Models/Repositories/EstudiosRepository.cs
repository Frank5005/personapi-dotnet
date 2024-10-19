using personapi_dotnet.Models.Entities;
using personapi_dotnet.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace personapi_dotnet.Models.Repositories
{
    public class EstudiosRepository : IEstudiosRepository
    {
        private readonly PersonaDbContext _context;

        public EstudiosRepository(PersonaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Estudio> GetAll() => _context.Estudios.ToList();

        public Estudio GetById(int id_prof, int cc_per) => _context.Estudios.Find(id_prof, cc_per);

        public void Add(Estudio estudios)
        {
            _context.Estudios.Add(estudios);
            _context.SaveChanges();
        }

        public void Update(Estudio estudios)
        {
            _context.Estudios.Update(estudios);
            _context.SaveChanges();
        }

        public void Delete(int id_prof, int cc_per)
        {
            var estudios = _context.Estudios.Find(id_prof, cc_per);
            if (estudios != null)
            {
                _context.Estudios.Remove(estudios);
                _context.SaveChanges();
            }
        }
    }
}