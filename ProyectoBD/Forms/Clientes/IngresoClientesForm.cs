using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD.Forms.Clientes
{
    public partial class IngresoClientesForm : Form
    {
        metodosClientes ingresar = new metodosClientes();
        public IngresoClientesForm()
        {
            InitializeComponent();
        }

        private void IngresoClientesForm_Load(object sender, EventArgs e)
        {
            Random numero = new Random();
            int var = numero.Next(1000000, 9999999);
            codigo_tbx.Text = Convert.ToString(var);
        }

        private void agregarCliente_btn_Click(object sender, EventArgs e)
        {
            if (nombre_tbx == null || apellidoPaterno_tbx == null || apellidoMaterno_tbx == null || direccion_tbx == null || telefono_tbx == null || email_tbx == null || codigo_tbx == null)
            {
                MessageBox.Show("No se pueden ingresar valores nulos");
            }
            if (nombre_tbx != null && apellidoPaterno_tbx != null && apellidoMaterno_tbx != null && direccion_tbx != null && telefono_tbx != null && email_tbx != null && codigo_tbx != null)
            {
                try
                {
                    if (ingresar.articuloRegistrado(Convert.ToInt32(codigo_tbx.Text),"CLIENTE") == 0)
                    {
                        try
                        {
                            ingresar.Insertar(Convert.ToInt32(codigo_tbx.Text),nombre_tbx.Text,apellidoPaterno_tbx.Text,
                                apellidoMaterno_tbx.Text,direccion_tbx.Text,telefono_tbx.Text,email_tbx.Text);
                            nombre_tbx.Clear();                            
                            codigo_tbx.Clear();
                            apellidoMaterno_tbx.Clear();
                            apellidoPaterno_tbx.Clear();
                            direccion_tbx.Clear();
                            telefono_tbx.Clear();
                            email_tbx.Clear();
                            MessageBox.Show("Cliente agregado correctamente");
                        }
                        catch
                        {
                            MessageBox.Show("No se pueden ingresar letras en el campo de precio");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("No se pueden ingresar letras en el campo de codigo");
                }

            }
        }
    }
}
