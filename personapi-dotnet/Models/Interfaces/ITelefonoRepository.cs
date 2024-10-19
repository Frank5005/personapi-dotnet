using personapi_dotnet.Models.Entities;
using System.Collections.Generic;

namespace personapi_dotnet.Models.Interfaces
{
    public interface ITelefonoRepository
    {
        IEnumerable<Telefono> GetAll();
        Telefono GetById(string num);
        void Add(Telefono telefono);
        void Update(Telefono telefono);
        void Delete(string num);
    }
}