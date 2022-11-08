using CadMinerva;
using ClnMinerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpMinerva
{
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            dtpFecha.MaxDate = DateTime.Now;
            dtpFecha.MinDate = DateTime.Now.AddDays(-30);
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            cbxProveedor.DataSource = ProveedorCln.listar();
            cbxProveedor.ValueMember = "id";
            cbxProveedor.DisplayMember = "razonSocial";
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            new FrmBuscarProducto().ShowDialog();
            if (FrmBuscarProducto.producto != null)
            {
                // Agregar a la tabla (dgvLista)
                dgvLista.Rows.Add(new DataGridViewRow() { });
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var compra = new Compra();
            compra.transaccion = 1; // Generar número de transacción
            compra.fecha = dtpFecha.Value;
            compra.idProveedor = Convert.ToInt32(cbxProveedor.SelectedValue);
            compra.usuarioRegistro = Util.usuario.usuario;
            compra.fechaRegistro = DateTime.Now;
            compra.registroActivo = true;
            int idCompra = 0; // CompraCln.insertar(compra);

            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                var compraDetalle = new CompraDetalle();
                compraDetalle.idCompra = idCompra;
                compraDetalle.idProducto = Convert.ToInt32(row.Cells["idProducto"].Value);
                compraDetalle.cantidad = Convert.ToDecimal(row.Cells["cantidad"].Value);
                compraDetalle.precioUnitario = Convert.ToDecimal(row.Cells["precioUnitario"].Value);
                compraDetalle.total = Convert.ToDecimal(row.Cells["total"].Value);
                compraDetalle.usuarioRegistro = Util.usuario.usuario;
                compraDetalle.fechaRegistro = DateTime.Now;
                compraDetalle.registroActivo = true;
                // CompraDetalleCln.insertar(compraDetalle);

                // Actualizar el Stock -> ProductoCln.actualizarStock(id, cantidadAdicional);
            }
            // Mensaje
            // Abrir un reporte del registra de la compra
            Close();
        }
    }
}
