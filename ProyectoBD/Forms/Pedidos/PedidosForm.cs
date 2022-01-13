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
    public partial class PedidosForm : Form
    {
        public PedidosForm()
        {
            InitializeComponent();
        }

        public void AddForm(Form x)
        {
            if (this.panelPedidos.Controls.Count > 0)
            {
                this.panelPedidos.Controls.Remove(ingresarPedido_btn);
                this.panelPedidos.Controls.Remove(verPedido_btn);
                this.panelPedidos.Controls.Remove(modificarPedido_btn);
                this.panelPedidos.Controls.Remove(cancelarPedido_btn);
            }

            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.panelPedidos.Controls.Add(x);
            x.Show();
        }

        private void ingresarPedido_btn_Click(object sender, EventArgs e)
        {
            Form ingresarPedido = new Forms.Pedidos.IngresarPedidoForm();
            AddForm(ingresarPedido);
        }

        private void verPedido_btn_Click(object sender, EventArgs e)
        {
            Form verPedido = new Forms.Pedidos.VerPedidoForm();
            AddForm(verPedido);
        }

        private void modificarPedido_btn_Click(object sender, EventArgs e)
        {
            Form modificarPedido = new Forms.Pedidos.ModificarPedidoForm();
            AddForm(modificarPedido);
        }

        private void cancelarPedido_btn_Click(object sender, EventArgs e)
        {
            Form cancelarPedido = new Forms.Pedidos.CancelarPedidoForm();
            AddForm(cancelarPedido);
        }
    }
}
