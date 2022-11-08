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
    public partial class FrmEmpleado : Form
    {
        bool esNuevo = true;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            txtNombre.KeyPress += Util.onlyLetters;
            txtPaterno.KeyPress += Util.onlyLetters;
            txtMaterno.KeyPress += Util.onlyLetters;
            txtCelular.KeyPress += Util.onlyNumbers;
            Size = new Size(1039, 423);
            listar();
        }

        private void listar()
        {
            var empleado = UsuarioCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = empleado;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idEmpleado"].Visible = false;
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "C.I.";
            dgvLista.Columns["nombre"].HeaderText = "Nombres";
            dgvLista.Columns["paterno"].HeaderText = "Ap. Paterno";
            dgvLista.Columns["materno"].HeaderText = "Ap. Materno";
            dgvLista.Columns["direccion"].HeaderText = "Dirección";
            dgvLista.Columns["celular"].HeaderText = "Celular";
            dgvLista.Columns["cargo"].HeaderText = "Cargo";
            dgvLista.Columns["usuario"].HeaderText = "Usuario";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            btnEditar.Enabled = empleado.Count > 0;
            btnEliminar.Enabled = empleado.Count > 0;
            if (empleado.Count > 0) dgvLista.Rows[0].Cells["cedulaIdentidad"].Selected = true;
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
            txtCI.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(1039, 578);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var empleado = EmpleadoCln.get(id);

            txtCI.Text = empleado.cedulaIdentidad;
            txtNombre.Text = empleado.nombre;
            txtPaterno.Text = empleado.paterno;
            txtMaterno.Text = empleado.materno;
            txtDireccion.Text = empleado.direccion;
            txtCelular.Text = empleado.celular.ToString();
            cbxCargo.Text = empleado.cargo;
            txtCI.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(1039, 423);
            limpiar();
        }

        private void limpiar()
        {
            txtCI.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPaterno.Text = String.Empty;
            txtMaterno.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtCelular.Text = String.Empty;
            cbxCargo.SelectedIndex = -1;
            txtUsuario.Text = String.Empty;
        }

        private bool validar()
        {
            bool esValido = true;
            erpCi.SetError(txtCI, "");
            erpNombre.SetError(txtNombre, "");
            erpApellido.SetError(txtPaterno, "");
            erpDireccion.SetError(txtDireccion, "");
            erpCelular.SetError(txtCelular, "");
            erpCargo.SetError(cbxCargo, "");
            erpUsuario.SetError(txtUsuario, "");

            if (string.IsNullOrEmpty(txtCI.Text))
            {
                erpCi.SetError(txtCI, "El campo Cédula de Identidad es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpNombre.SetError(txtNombre, "El campo Descripción es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtPaterno.Text) && string.IsNullOrEmpty(txtMaterno.Text))
            {
                erpApellido.SetError(txtPaterno, "Se debe cargar al menos un apellido");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                erpDireccion.SetError(txtDireccion, "El campo Dirección de Venta es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                erpCelular.SetError(txtCelular, "El campo Celular es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(cbxCargo.Text))
            {
                erpCargo.SetError(cbxCargo, "El campo Cargo es obligatorio");
                esValido = false;
            }
            if (chkUsuario.Checked && string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El campo Usuario es obligatorio");
                esValido = false;
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var empleado = new Empleado();
                empleado.cedulaIdentidad = txtCI.Text.Trim();
                empleado.nombre = txtNombre.Text.Trim();
                empleado.paterno = txtPaterno.Text.Trim();
                empleado.materno = txtMaterno.Text.Trim();
                empleado.direccion = txtDireccion.Text.Trim();
                empleado.celular = Convert.ToInt64(txtCelular.Text);
                empleado.cargo = cbxCargo.Text;
                empleado.usuarioRegistro = Util.usuario.usuario;
                empleado.fechaRegistro = DateTime.Now;

                if (esNuevo)
                {
                    empleado.registroActivo = true;
                    int idEmpleado = EmpleadoCln.insertar(empleado);

                    if (chkUsuario.Checked)
                    {
                        var usuario = new Usuario();
                        usuario.usuario = txtUsuario.Text.Trim();
                        usuario.clave = Util.Encrypt("SIS457");
                        usuario.idEmpleado = idEmpleado;
                        usuario.usuarioRegistro = "sis457";
                        usuario.fechaRegistro = DateTime.Now;
                        usuario.registroActivo = true;
                        UsuarioCln.insertar(usuario);
                    }
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    empleado.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    EmpleadoCln.actualizar(empleado);
                }

                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Empleado guardado correctamente", "::: Mensaje - Minerva :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string ci = dgvLista.Rows[index].Cells["cedulaIdentidad"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el empleaod con CI {ci}?", "::: Pregunta - Minerva :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                EmpleadoCln.eliminar(id, "sis457");
                listar();
                MessageBox.Show("Empleado dado de baja correctamente", "::: Mensaje - Minerva :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Visible = chkUsuario.Checked;
        }

        // Validar para casos con usuario -> Pendiente
    }
}
