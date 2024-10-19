﻿using System;
using System.Collections.Generic;

namespace personapi_dotnet.Models.Entities;

public partial class Telefono
{
    public string Num { get; set; } = null!;

    public string Oper { get; set; } = null!;

    public long Duenio { get; set; }

    public virtual Persona DuenioNavigation { get; set; } = null!;
}
