using System;
using System.Collections.Generic;

namespace WebMinervaNetCore.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public int IdEmpleado { get; set; }

    public string? UsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? RegistroActivo { get; set; }

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;
}
