using System;
using System.Collections.Generic;

namespace ClinicaDentalWEB.Models;

public partial class Pago
{
    public int IdPago { get; set; }

    public decimal? Monto { get; set; }

    public DateTime? Fecha { get; set; }

    public string? MetodoPago { get; set; }

    public string? EstadoPago { get; set; }

    public string? Detalles { get; set; }

    public int? IdFactura { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }
}
