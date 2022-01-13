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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        public void AddForm(Form x) 
        {
            if (this.panelInfo.Controls.Count > 0)
            {
                this.panelInfo.Controls.RemoveAt(0);
            }

            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.panelInfo.Controls.Add(x);
            x.Show();
        }
        
        private void articulos_btn_Click(object sender, EventArgs e)
        {
            Form articulosForm = new ArticulosForm();
            AddForm(articulosForm);
        }

        private void pedidos_btn_Click(object sender, EventArgs e)
        {
            Form pedidosForm = new PedidosForm();
            AddForm(pedidosForm);
        }

        private void transporte_btn_Click(object sender, EventArgs e)
        {
            Form transporteForm = new TransportesForm();
            AddForm(transporteForm);
        }

        private void locales_btn_Click(object sender, EventArgs e)
        {
            Form localesForm = new LocalesForm();
            AddForm(localesForm);
        }

        private void clientes_btn_Click(object sender, EventArgs e)
        {
            Form clientesForm = new ClientesForm();
            AddForm(clientesForm);
        }
    }
}
