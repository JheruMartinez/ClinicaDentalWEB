using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class Citum
{
    public int IdCita { get; set; }

    public string? Estado { get; set; }

    public DateOnly? Fecha { get; set; }

    public TimeOnly? Hora { get; set; }

    public string? Duracion { get; set; }

    public string? Motivo { get; set; }

    public int? IdPaciente { get; set; }

    public int? IdDentista { get; set; }

    public int? IdTratamiento { get; set; }

    public virtual ICollection<Consultum> Consulta { get; set; } = new List<Consultum>();

    public virtual Dentistum? IdDentistaNavigation { get; set; }

    public virtual Paciente? IdPacienteNavigation { get; set; }

    public virtual Tratamiento? IdTratamientoNavigation { get; set; }
}
