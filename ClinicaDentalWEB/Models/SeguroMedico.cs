using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class SeguroMedico
{
    public int IdSeguro { get; set; }

    public string? NombreSeguro { get; set; }

    public string? CodigoSeguro { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Cobertura { get; set; }

    public int? IdPaciente { get; set; }

    public virtual Paciente? IdPacienteNavigation { get; set; }
}
