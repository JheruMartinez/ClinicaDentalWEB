using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class Consultum
{
    public int IdConsulta { get; set; }

    public string? Diagnostico { get; set; }

    public string? Observaciones { get; set; }

    public int? IdTratamiento { get; set; }

    public int? IdCita { get; set; }

    public virtual ICollection<HistorialMedico> HistorialMedicos { get; set; } = new List<HistorialMedico>();

    public virtual Citum? IdCitaNavigation { get; set; }

    public virtual Tratamiento? IdTratamientoNavigation { get; set; }
}
