using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class Permiso
{
    public int IdPermiso { get; set; }

    public string? Nombre { get; set; }

    public string? Description { get; set; }

    public int? CreadoPor { get; set; }

    public int? ActualizadoPor { get; set; }

    public virtual Usuario? ActualizadoPorNavigation { get; set; }

    public virtual Usuario? CreadoPorNavigation { get; set; }

    public virtual ICollection<PermisosRolPermiso> PermisosRolPermisos { get; set; } = new List<PermisosRolPermiso>();
}
