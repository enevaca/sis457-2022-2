using System;
using System.Collections.Generic;

namespace WebMinervaNetCore.Models;

public partial class Proveedor
{
    public int Id { get; set; }

    public string Nit { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Representante { get; set; } = null!;

    public string? UsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? RegistroActivo { get; set; }

    public virtual ICollection<Compra> Compras { get; } = new List<Compra>();
}
