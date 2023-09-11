using System;
using System.Collections.Generic;

namespace Parcial.Models;

public partial class Mecanico
{
    public int IdMecanico { get; set; }

    public string? NombreMecan { get; set; }

    public int? IdCliente { get; set; }

    public int? IdVehiculo { get; set; }
}
