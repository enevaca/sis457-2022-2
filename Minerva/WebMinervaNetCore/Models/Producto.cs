using System;
using System.Collections.Generic;

namespace WebMinervaNetCore.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public decimal Saldo { get; set; }

    public decimal PrecioVenta { get; set; }

    public string? UsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? RegistroActivo { get; set; }

    public virtual ICollection<CompraDetalle> CompraDetalles { get; } = new List<CompraDetalle>();
}
