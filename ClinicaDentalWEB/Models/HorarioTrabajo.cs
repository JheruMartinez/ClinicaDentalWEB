using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class HorarioTrabajo
{
    public int IdHorario { get; set; }

    public string? DiaSemana { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public TimeOnly? HoraFin { get; set; }

    public int? IdDentista { get; set; }
}
