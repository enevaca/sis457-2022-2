using System;
using System.Windows.Forms;

namespace CpMinerva
{
    public partial class FrmPrincipal : Form
    {
        FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAutenticacion.Visible = true;
        }

        private void btnCaProducto_Click(object sender, EventArgs e)
        {
            new FrmProducto().ShowDialog();
        }

        private void btnAdmEmpleado_Click(object sender, EventArgs e)
        {
            new FrmEmpleado().ShowDialog();
        }

        private void btnCvCompra_Click(object sender, EventArgs e)
        {
            new FrmCompra().ShowDialog();
        }

        private void btnCvVenta_Click(object sender, EventArgs e)
        {
            new FrmVenta().ShowDialog();
        }
    }
}
