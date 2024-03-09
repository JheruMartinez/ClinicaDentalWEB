using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class Especialidad
{
    public int IdEspecialidad { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public DateOnly? FechaActualizacion { get; set; }
}
