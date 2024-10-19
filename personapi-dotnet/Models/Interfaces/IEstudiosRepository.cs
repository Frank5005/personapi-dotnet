using personapi_dotnet.Models.Entities;
using System.Collections.Generic;

namespace personapi_dotnet.Models.Interfaces
{
    public interface IEstudiosRepository
    {
        IEnumerable<Estudio> GetAll();
        Estudio GetById(int id_prof, int cc_per);
        void Add(Estudio estudios);
        void Update(Estudio estudios);
        void Delete(int id_prof, int cc_per);
    }
}