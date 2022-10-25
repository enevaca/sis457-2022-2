using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class ProveedorCln
    {
        public static int insertar(Proveedor proveedor)
        {
            using (var contexto = new MinervaEntities())
            {
                contexto.Proveedor.Add(proveedor);
                contexto.SaveChanges();
                return proveedor.id;
            }
        }

        public static int actualizar(Proveedor proveedor)
        {
            using (var contexto = new MinervaEntities())
            {
                var existente = contexto.Proveedor.Find(proveedor.id);
                existente.nit = proveedor.nit.Trim();
                existente.razonSocial = proveedor.razonSocial.Trim();
                existente.direccion = proveedor.direccion.Trim();
                existente.telefono = proveedor.telefono.Trim();
                existente.representante = proveedor.representante;
                existente.usuarioRegistro = proveedor.usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var contexto = new MinervaEntities())
            {
                var existente = contexto.Proveedor.Find(id);
                existente.registroActivo = false;
                existente.usuarioRegistro = usuario;
                return contexto.SaveChanges();
            }
        }

        public static Proveedor get(int id)
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Proveedor.Find(id);
            }
        }

        public static List<Proveedor> listar()
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Proveedor.Where(x => x.registroActivo.Value).ToList();
            }
        }

        //public static List<paProductoListar_Result> listarPa(string parametro)
        //{
        //    using (var contexto = new MinervaEntities())
        //    {
        //        return contexto.paProveedorListar(parametro).ToList();
        //    }
        //}
    }
}
