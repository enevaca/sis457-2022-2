using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class ProdutoCln
    {
        public static int insertar(Producto producto) // INSERT INT Producto VALUES (....)
        {
            using (var contexto = new MinervaEntities())
            {
                contexto.Producto.Add(producto);
                contexto.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto) // UPDATE Producto SET .... WHERE id=...
        {
            using (var contexto = new MinervaEntities())
            {
                var existente = contexto.Producto.Find(producto.id);
                existente.codigo = producto.codigo.Trim();
                existente.descripcion = producto.descripcion.Trim();
                existente.unidadMedida = producto.unidadMedida.Trim();
                existente.saldo = producto.saldo;
                existente.precioVenta = producto.precioVenta;
                existente.usuarioRegistro = producto.usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario) // UPDATE Producto SET registroActivo=0, usu... WHERE id=...
        {
            using (var contexto = new MinervaEntities())
            {
                var existente = contexto.Producto.Find(id);
                existente.registroActivo = false;
                existente.usuarioRegistro = usuario;
                return contexto.SaveChanges();
            }
        }

        public static Producto get(int id) // SELECT * FROM Producto WHERE id=...
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Producto.Find(id);
            }
        }

        public static List<Producto> listar() // SELECT * FROM Producto WHERE registroActivo=1
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Producto.Where(x => x.registroActivo.Value).ToList();
            }
        }

        public static List<paProductoListar_Result> listarPa(string parametro) // EXEC paProductoListar ''
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.paProductoListar(parametro).ToList();
            }
        }
    }
}
