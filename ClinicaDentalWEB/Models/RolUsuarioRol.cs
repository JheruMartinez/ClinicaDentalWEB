using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class RolUsuarioRol
{
    public int RolUsuarioIdRol { get; set; }

    public int RolIdRol { get; set; }

    public virtual Rol RolIdRolNavigation { get; set; } = null!;
}
