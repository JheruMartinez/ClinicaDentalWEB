using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Usuario1 { get; set; }

    public string? Contra { get; set; }

    public string? Email { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public virtual ICollection<Permiso> PermisoActualizadoPorNavigations { get; set; } = new List<Permiso>();

    public virtual ICollection<Permiso> PermisoCreadoPorNavigations { get; set; } = new List<Permiso>();

    public virtual ICollection<Rol> RolActualizadoPorNavigations { get; set; } = new List<Rol>();

    public virtual ICollection<Rol> RolCreadoPorNavigations { get; set; } = new List<Rol>();

    public virtual ICollection<RolUsuarioUsuario> RolUsuarioUsuarios { get; set; } = new List<RolUsuarioUsuario>();
}
