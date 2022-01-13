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
    public partial class ArticulosForm : Form
    {
        public ArticulosForm()
        {
            InitializeComponent();
        }

        public void AddForm(Form x)
        {
            if (this.panelInfo.Controls.Count > 0)
            {
                this.panelInfo.Controls.Remove(ingresarArt_btn);
                this.panelInfo.Controls.Remove(verArt_btn);
                this.panelInfo.Controls.Remove(modificarArt_btn);
                this.panelInfo.Controls.Remove(eliminarArt_btn);
            }

            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.panelInfo.Controls.Add(x);
            x.Show();
        }

        private void ingresarArt_btn_Click(object sender, EventArgs e)
        {
            Form ingresoArt = new IngresoArticulos();
            AddForm(ingresoArt);
        }

        private void verArt_btn_Click(object sender, EventArgs e)
        {
            Form verArt = new verArt();
            AddForm(verArt);
        }

        private void modificarArt_btn_Click(object sender, EventArgs e)
        {
            Form modificar = new Forms.ModificarArtForm();
            AddForm(modificar);
        }

        private void eliminarArt_btn_Click(object sender, EventArgs e)
        {
            Form eliminar = new Forms.EliminarArtForm();
            AddForm(eliminar);
        }
    }
}
