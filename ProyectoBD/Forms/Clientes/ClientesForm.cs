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
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        public void AddForm(Form x)
        {
            if (this.panelClientes.Controls.Count > 0)
            {
                this.panelClientes.Controls.Remove(ingresarCliente_btn);
                this.panelClientes.Controls.Remove(verClientes_btn);
                this.panelClientes.Controls.Remove(modificarClientes_btn);
                this.panelClientes.Controls.Remove(eliminarCliente_btn);
            }

            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.panelClientes.Controls.Add(x);
            x.Show();
        }

        private void ingresarCliente_btn_Click(object sender, EventArgs e)
        {
            Form ingresar = new Forms.Clientes.IngresoClientesForm();
            AddForm(ingresar);
        }

        private void verClientes_btn_Click(object sender, EventArgs e)
        {
            Form ver = new Forms.Clientes.VerClientesForm();
            AddForm(ver);
        }

        private void modificarClientes_btn_Click(object sender, EventArgs e)
        {
            Form modificar = new Forms.Clientes.ModificarClientesForm();
            AddForm(modificar);
        }

        private void eliminarCliente_btn_Click(object sender, EventArgs e)
        {
            Form eliminar = new Forms.Clientes.EliminarClientesForm();
            AddForm(eliminar);
        }
    }
}
