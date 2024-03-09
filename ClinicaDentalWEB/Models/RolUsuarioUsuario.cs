using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class RolUsuarioUsuario
{
    public int RolUsuarioIdUsuario { get; set; }

    public int UsuarioIdUsuario { get; set; }

    public virtual Usuario UsuarioIdUsuarioNavigation { get; set; } = null!;
}
