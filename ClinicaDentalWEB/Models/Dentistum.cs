using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class Dentistum
{
    public int IdDentista { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Apellido2 { get; set; }

    public string? Identificacion { get; set; }

    public string? Telefono { get; set; }

    public string? Genero { get; set; }

    public string? Direccion { get; set; }

    public string? Pais { get; set; }

    public string? Email { get; set; }

    public byte[]? Exequatur { get; set; }

    public string? DiasConsultas { get; set; }

    public int? IdEspecialidad { get; set; }

    public int? IdHorario { get; set; }

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();
}
