using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class TransportesForm : Form
    {
        public TransportesForm()
        {
            InitializeComponent();
        }

        public void AddForm(Form x)
        {
            if (this.panelTransporte.Controls.Count > 0)
            {
                this.panelTransporte.Controls.Remove(ingresarTransporte_btn);
                this.panelTransporte.Controls.Remove(verTransporte_btn);
                this.panelTransporte.Controls.Remove(modificarTransporte_btn);
                this.panelTransporte.Controls.Remove(cancelarTransporte_btn);
            }

            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.panelTransporte.Controls.Add(x);
            x.Show();
        }

        private void ingresarTransporte_btn_Click(object sender, EventArgs e)
        {
            Form ingresarTransporte = new Forms.Transporte.IngresarTransporteForm();
            AddForm(ingresarTransporte);
        }

        private void verTransporte_btn_Click(object sender, EventArgs e)
        {
            Form verTransporte = new Forms.Transporte.VerTransporteForm();
            AddForm(verTransporte);
        }

        private void modificarTransporte_btn_Click(object sender, EventArgs e)
        {
            Form modificarTransporte = new Forms.Transporte.ModificarTransporteForm();
            AddForm(modificarTransporte);
        }

        private void cancelarTransporte_btn_Click(object sender, EventArgs e)
        {
            Form eliminarTransporte = new Forms.Transporte.EliminarTransporteForm();
            AddForm(eliminarTransporte);
        }
    }
}
