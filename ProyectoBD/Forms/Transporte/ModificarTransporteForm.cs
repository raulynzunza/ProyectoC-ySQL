using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD.Forms.Transporte
{
    public partial class ModificarTransporteForm : Form
    {
        public ModificarTransporteForm()
        {
            InitializeComponent();
        }
        metodosTransporte metodo = new metodosTransporte();
        Clases.Conexion conexion = new Clases.Conexion();
        private void ModificarTransporteForm_Load(object sender, EventArgs e)
        {
            codigoLocal_cbx.DataSource = metodo.CargarCombo("LOCAL","codigo_local");
            codigoLocal_cbx.DisplayMember = "codigo_local";
            codigoLocal_cbx.ValueMember = "codigo_local";
            codigoTransporte_cbx.DataSource = metodo.CargarCombo("TRANSPORTE","cod_trans");
            codigoTransporte_cbx.DisplayMember = "cod_trans";
            codigoTransporte_cbx.ValueMember = "cod_trans";
            string consulta = "SELECT * FROM VISTA2";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvTransportes.DataSource = tabla;

            this.dgvTransportes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvTransportes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvTransportes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            if (codigoLocal_cbx != null && nombre_tbx != null && apellidoPaterno_tbx != null && apellidoMaterno_tbx != null && codigoTransporte_cbx != null)
            {
                try
                {
                    metodo.Modificar(nombre_tbx.Text,apellidoPaterno_tbx.Text,apellidoMaterno_tbx.Text,Convert.ToInt32(codigoTransporte_cbx.SelectedValue),Convert.ToInt32(codigoLocal_cbx.SelectedValue));
                    string consulta = "SELECT * FROM VISTA2";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvTransportes.DataSource = tabla;
                    nombre_tbx.Clear();
                    apellidoPaterno_tbx.Clear();
                    apellidoMaterno_tbx.Clear();
                }
                catch
                {
                    MessageBox.Show("No se pueden ingresar letras en el campo de codigo");
                }
            }
            else
            {
                MessageBox.Show("No se pueden ingresar valores nulos");
            }
        }
    }
}
