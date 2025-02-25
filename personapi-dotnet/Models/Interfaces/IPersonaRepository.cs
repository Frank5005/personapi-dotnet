﻿using personapi_dotnet.Models.Entities;
using System.Collections.Generic;

namespace personapi_dotnet.Models.Interfaces
{
    public interface IPersonaRepository
    {
        IEnumerable<Persona> GetAll();
        Persona GetById(int cc);
        void Add(Persona persona);
        void Update(Persona persona);
        void Delete(int cc);
    }
}