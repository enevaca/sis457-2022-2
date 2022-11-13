using System;
using System.Collections.Generic;

namespace WebMinervaNetCore.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string CedulaIdentidad { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Paterno { get; set; } = null!;

    public string Materno { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public long Celular { get; set; }

    public string Cargo { get; set; } = null!;

    public string? UsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? RegistroActivo { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
