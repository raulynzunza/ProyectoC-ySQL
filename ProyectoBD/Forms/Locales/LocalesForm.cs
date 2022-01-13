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
    public partial class LocalesForm : Form
    {
        public LocalesForm()
        {
            InitializeComponent();
        }

        public void AddForm(Form x)
        {
            if (this.panelLocales.Controls.Count > 0)
            {
                this.panelLocales.Controls.Remove(ingresarLocales_btn);
                this.panelLocales.Controls.Remove(verLocales_btn);
                this.panelLocales.Controls.Remove(modificarLocales_btn);
                this.panelLocales.Controls.Remove(cancelarLocales_btn);
            }

            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.panelLocales.Controls.Add(x);
            x.Show();
        }

        private void ingresarLocales_btn_Click(object sender, EventArgs e)
        {
            Form ingresarLocales = new Forms.Locales.IngresarLocalesForm();
            AddForm(ingresarLocales);
        }

        private void verLocales_btn_Click(object sender, EventArgs e)
        {
            Form verLocales = new Forms.Locales.VerLocalesForm();
            AddForm(verLocales);
        }

        private void modificarLocales_btn_Click(object sender, EventArgs e)
        {
            Form modificarLocales = new Forms.Locales.ModificarLocalesForm();
            AddForm(modificarLocales);
        }

        private void cancelarLocales_btn_Click(object sender, EventArgs e)
        {
            Form cancelarLocales = new Forms.Locales.CancelarLocalesForm();
            AddForm(cancelarLocales);
        }
    }
}
