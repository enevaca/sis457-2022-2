﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CadMinerva
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class MinervaEntities : DbContext
{
    public MinervaEntities()
        : base("name=MinervaEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Compra> Compra { get; set; }

    public virtual DbSet<CompraDetalle> CompraDetalle { get; set; }

    public virtual DbSet<Empleado> Empleado { get; set; }

    public virtual DbSet<Producto> Producto { get; set; }

    public virtual DbSet<Proveedor> Proveedor { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }


    public virtual ObjectResult<paProductoListar_Result> paProductoListar(string parametro)
    {

        var parametroParameter = parametro != null ?
            new ObjectParameter("parametro", parametro) :
            new ObjectParameter("parametro", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paProductoListar_Result>("paProductoListar", parametroParameter);
    }


    public virtual ObjectResult<paEmpleadoListar_Result> paEmpleadoListar(string parametro)
    {

        var parametroParameter = parametro != null ?
            new ObjectParameter("parametro", parametro) :
            new ObjectParameter("parametro", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paEmpleadoListar_Result>("paEmpleadoListar", parametroParameter);
    }


    public virtual ObjectResult<paUsuarioListar_Result> paUsuarioListar(string parametro)
    {

        var parametroParameter = parametro != null ?
            new ObjectParameter("parametro", parametro) :
            new ObjectParameter("parametro", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paUsuarioListar_Result>("paUsuarioListar", parametroParameter);
    }

}

}

