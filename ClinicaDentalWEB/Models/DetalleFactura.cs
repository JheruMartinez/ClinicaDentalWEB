using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class DetalleFactura
{
    public int IdDetalleFactura { get; set; }

    public int? Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? Subtotal { get; set; }

    public int? IdFactura { get; set; }

    public int? IdTratamiento { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

    public virtual Tratamiento? IdTratamientoNavigation { get; set; }
}
