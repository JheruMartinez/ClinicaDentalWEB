using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class HistorialMedico
{
    public int IdHm { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Diagnostico { get; set; }

    public string? Procedimiento { get; set; }

    public string? Observaciones { get; set; }

    public int? IdPaciente { get; set; }

    public int? IdTratamiento { get; set; }

    public int? IdConsulta { get; set; }

    public virtual Consultum? IdConsultaNavigation { get; set; }

    public virtual Paciente? IdPacienteNavigation { get; set; }

    public virtual Tratamiento? IdTratamientoNavigation { get; set; }
}
