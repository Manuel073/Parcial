using System;
using System.Collections.Generic;

namespace Parcial.Models;

public partial class Vehiculo
{
    public int IdVehiculos { get; set; }

    public string? Matricula { get; set; }

    public string? Color { get; set; }

    public string? Modelo { get; set; }

    public int? IdMecanico { get; set; }

    public int? IdCliente { get; set; }
}
