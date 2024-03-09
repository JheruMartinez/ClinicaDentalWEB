using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class PermisosRolPermiso
{
    public int PermisosRolIdPermiso { get; set; }

    public int PermisoIdPermiso { get; set; }

    public virtual Permiso PermisoIdPermisoNavigation { get; set; } = null!;
}
