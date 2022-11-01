using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class EmpleadoCln
    {
        public static int insertar(Empleado empleado)
        {
            using (var contexto = new MinervaEntities())
            {
                contexto.Empleado.Add(empleado);
                contexto.SaveChanges();
                return empleado.id;
            }
        }

        public static int actualizar(Empleado empleado)
        {
            using (var contexto = new MinervaEntities())
            {
                var existente = contexto.Empleado.Find(empleado.id);
                existente.cedulaIdentidad = empleado.cedulaIdentidad.Trim();
                existente.nombre = empleado.nombre.Trim();
                existente.paterno = empleado.paterno.Trim();
                existente.materno = empleado.materno.Trim();
                existente.direccion = empleado.direccion;
                existente.celular = empleado.celular;
                existente.cargo = empleado.cargo;
                existente.usuarioRegistro = empleado.usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var contexto = new MinervaEntities())
            {
                var existente = contexto.Empleado.Find(id);
                existente.registroActivo = false;
                existente.usuarioRegistro = usuario;
                return contexto.SaveChanges();
            }
        }

        public static Empleado get(int id)
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Empleado.Find(id);
            }
        }

        public static List<Empleado> listar()
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Empleado.Where(x => x.registroActivo.Value).ToList();
            }
        }

        public static List<paEmpleadoListar_Result> listarPa(string parametro)
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.paEmpleadoListar(parametro).ToList();
            }
        }
    }
}
