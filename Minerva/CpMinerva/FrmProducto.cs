using CadMinerva;
using ClnMinerva;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CpMinerva
{
    public partial class FrmProducto : Form
    {
        bool esNuevo = true;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Size = new Size(1039, 423);
            listar();
        }

        private void listar() 
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
            if (productos.Count > 0) dgvLista.Rows[0].Cells["codigo"].Selected = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(1039, 578);
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(1039, 578);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var producto = ProductoCln.get(id);

            txtCodigo.Text = producto.codigo;
            txtDescripcion.Text = producto.descripcion;
            nudSaldo.Value = producto.saldo;
            nudPrecioVenta.Value = producto.precioVenta;
            cbxUnidadMedida.Text = producto.unidadMedida;
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(1039, 423);
            limpiar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpCodigo.SetError(txtCodigo, "");
            erpDescripcion.SetError(txtDescripcion, "");
            erpSaldo.SetError(nudSaldo, "");
            erpUnidadMedida.SetError(cbxUnidadMedida, "");
            erpPrecioVenta.SetError(nudPrecioVenta, "");

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                erpCodigo.SetError(txtCodigo, "El campo Código es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                erpDescripcion.SetError(txtDescripcion, "El campo Descripción es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(nudSaldo.Text))
            {
                erpSaldo.SetError(nudSaldo, "El campo Saldo es obligatorio");
                esValido = false;
            }
            if (nudSaldo.Value < 0)
            {
                erpSaldo.SetError(nudSaldo, "El campo Saldo No debe ser negativo");
                esValido = false;
            }
            if (string.IsNullOrEmpty(nudPrecioVenta.Text))
            {
                erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta es obligatorio");
                esValido = false;
            }
            if (nudPrecioVenta.Value < 0)
            {
                erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta No debe ser negativo");
                esValido = false;
            }
            if (string.IsNullOrEmpty(cbxUnidadMedida.Text))
            {
                erpUnidadMedida.SetError(cbxUnidadMedida, "El campo Unidad de Medida es obligatorio");
                esValido = false;
            }
            return esValido;
        }

        private void limpiar()
        { 
            txtCodigo.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            nudSaldo.Value = 0;
            nudPrecioVenta.Value = 0;
            cbxUnidadMedida.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var producto = new Producto();
                producto.codigo = txtCodigo.Text.Trim();
                producto.descripcion = txtDescripcion.Text.Trim();
                producto.unidadMedida = cbxUnidadMedida.Text;
                producto.saldo = nudSaldo.Value;
                producto.precioVenta = nudPrecioVenta.Value;
                producto.usuarioRegistro = Util.usuario.usuario;
                producto.fechaRegistro = DateTime.Now;

                if (esNuevo)
                {
                    producto.registroActivo = true;
                    ProductoCln.insertar(producto);
                }
                else 
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    producto.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    ProductoCln.actualizar(producto);
                }

                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Producto guardado correctamente", "::: Mensaje - Minerva :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string codigo = dgvLista.Rows[index].Cells["codigo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el producto con código {codigo}?", "::: Pregunta - Minerva :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ProductoCln.eliminar(id, "sis457");
                listar();
                MessageBox.Show("Producto dado de baja correctamente", "::: Mensaje - Minerva :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
