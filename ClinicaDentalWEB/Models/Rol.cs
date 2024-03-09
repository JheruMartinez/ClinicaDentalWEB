using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class Rol
{
    public int IdRol { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? CreadoPor { get; set; }

    public int? ActualizadoPor { get; set; }

    public virtual Usuario? ActualizadoPorNavigation { get; set; }

    public virtual Usuario? CreadoPorNavigation { get; set; }

    public virtual ICollection<PermisosRolRol> PermisosRolRols { get; set; } = new List<PermisosRolRol>();

    public virtual ICollection<RolUsuarioRol> RolUsuarioRols { get; set; } = new List<RolUsuarioRol>();
}
