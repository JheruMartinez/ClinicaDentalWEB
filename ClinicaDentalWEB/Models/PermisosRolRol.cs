using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class PermisosRolRol
{
    public int PermisosRolIdRol { get; set; }

    public int RolIdRol { get; set; }

    public virtual Rol RolIdRolNavigation { get; set; } = null!;
}
