using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD.Forms.Locales
{
    public partial class IngresarLocalesForm : Form
    {
        metodosLocales ingresar = new metodosLocales();

        public IngresarLocalesForm()
        {
            InitializeComponent();
        }

        private void IngresarLocalesForm_Load(object sender, EventArgs e)
        {
            Random numero = new Random();
            int var = numero.Next(100000, 999999);
            codigo_tbx.Text = Convert.ToString(var);
        }

        private void agregarLocales_btn_Click(object sender, EventArgs e)
        {
            if (nombre_tbx == null || direccion_tbx == null || codigo_tbx == null)
            {
                MessageBox.Show("No se pueden ingresar valores nulos");
            }
            if (nombre_tbx != null && direccion_tbx != null && codigo_tbx != null)
            {
                try
                {
                    if (ingresar.articuloRegistrado(Convert.ToInt32(codigo_tbx.Text), "LOCAL") == 0)
                    {
                        try
                        {
                            ingresar.Insertar(Convert.ToInt32(codigo_tbx.Text), nombre_tbx.Text, direccion_tbx.Text);
                            nombre_tbx.Clear();
                            codigo_tbx.Clear();
                            direccion_tbx.Clear();                                                        
                            MessageBox.Show("Local agregado correctamente");
                            Random numero = new Random();
                            int var = numero.Next(100000, 999999);
                            codigo_tbx.Text = Convert.ToString(var);
                        }
                        catch
                        {
                            
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
