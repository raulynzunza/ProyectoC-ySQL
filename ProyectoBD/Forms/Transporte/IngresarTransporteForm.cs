using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD.Forms.Transporte
{
    public partial class IngresarTransporteForm : Form
    {
        metodosTransporte metodo = new metodosTransporte();
        public IngresarTransporteForm()
        {
            InitializeComponent();
        }

        private void IngresarTransporteForm_Load(object sender, EventArgs e)
        {
            codigoLocal_cbx.DataSource = metodo.CargarCombo("LOCAL","codigo_local");
            codigoLocal_cbx.DisplayMember = "codigo_local";
            codigoLocal_cbx.ValueMember = "codigo_local";
            Random numero = new Random();
            int var = numero.Next(10000000, 99999999);
            codigo_tbx.Text = Convert.ToString(var);
        }

        private void agregarTransporte_btn_Click(object sender, EventArgs e)
        {
            if (nombre_tbx == null || apellidoPaterno_tbx == null || apellidoMaterno_tbx == null || codigo_tbx == null || codigoLocal_cbx == null)
            {
                MessageBox.Show("No se pueden ingresar valores nulos");
            }
            if (nombre_tbx != null && apellidoPaterno_tbx != null && apellidoMaterno_tbx != null && codigo_tbx != null && codigoLocal_cbx != null)
            {
                try
                {
                    if (metodo.articuloRegistrado(Convert.ToInt32(codigo_tbx.Text), "TRANSPORTE") == 0)
                    {
                        try
                        {
                            metodo.Insertar(nombre_tbx.Text, apellidoPaterno_tbx.Text, apellidoMaterno_tbx.Text, Convert.ToInt32(codigo_tbx.Text), Convert.ToInt32(codigoLocal_cbx.SelectedValue));
                            nombre_tbx.Clear();
                            codigo_tbx.Clear();
                            apellidoMaterno_tbx.Clear();
                            apellidoPaterno_tbx.Clear();
                            codigoLocal_cbx.Refresh();
                            MessageBox.Show("Transporte agregado correctamente");
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
