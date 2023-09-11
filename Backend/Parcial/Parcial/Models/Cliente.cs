using System;
using System.Collections.Generic;

namespace Parcial.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? NombreClien { get; set; }

    public int? IdVehiculo { get; set; }

    public string? IdMecanico { get; set; }
}
