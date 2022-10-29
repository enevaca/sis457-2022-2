using CadMinerva;
using ClnMinerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpMinerva
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Size = new Size(1039, 423);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(1039, 578);
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(1039, 578);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(1039, 423);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var productos = ProductoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = productos;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
            dgvLista.Columns["saldo"].HeaderText = "Saldo";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio de Venta";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            btnEditar.Enabled = productos.Count > 0;
            btnEliminar.Enabled = productos.Count > 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var producto = new Producto();
            producto.codigo = txtCodigo.Text.Trim();
            producto.descripcion = txtDescripcion.Text.Trim();
            producto.unidadMedida = cbxUnidadMedida.SelectedText;
            producto.saldo = nudSaldo.Value;
            producto.precioVenta = nudPrecioVenta.Value;
            producto.usuarioRegistro = "sis457";
            producto.fechaRegistro = DateTime.Now;
            producto.registroActivo = true;
            ProductoCln.insertar(producto);
            btnBuscar.PerformClick();
            MessageBox.Show("Producto Insertado correctamente");
        }
    }
}
