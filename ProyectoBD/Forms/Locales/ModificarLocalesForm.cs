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

namespace ProyectoBD.Forms.Locales
{
    public partial class ModificarLocalesForm : Form
    {
        public ModificarLocalesForm()
        {
            InitializeComponent();
        }
        Clases.Conexion conexion = new Clases.Conexion();
        metodosLocales metodo = new metodosLocales();
        private void ModificarLocalesForm_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT codigo_local AS 'Codigo de local', nombre AS 'Nombre de local'," +
                " direccion AS 'Direccion' FROM LOCAL ORDER BY codigo_local ASC";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvLocales.DataSource = tabla;

            this.dgvLocales.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvLocales.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvLocales.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            if (codigo_tbx != null && nombre_tbx != null && direccion_tbx != null)
            {
                try
                {
                    metodo.Modificar(Convert.ToInt32(codigo_tbx.Text), direccion_tbx.Text, nombre_tbx.Text);
                    string consulta = "SELECT codigo_local AS 'Codigo de local', nombre AS 'Nombre de local'" +
                ", direccion AS 'Direccion' FROM LOCAL ORDER BY codigo_local ASC";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvLocales.DataSource = tabla;
                    nombre_tbx.Clear();
                    codigo_tbx.Clear();                 
                    direccion_tbx.Clear();                    
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
