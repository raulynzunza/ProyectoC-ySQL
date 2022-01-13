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
    public partial class CancelarLocalesForm : Form
    {
        public CancelarLocalesForm()
        {
            InitializeComponent();
        }
        Clases.Conexion conexion = new Clases.Conexion();
        private void CancelarLocalesForm_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT codigo_local AS 'Codigo de local', nombre AS 'Nombre del local'" +
                " FROM LOCAL ORDER BY codigo_local ASC";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvLocales.DataSource = tabla;

            this.dgvLocales.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvLocales.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                SqlCommand cmd2 = new SqlCommand("DELETE FROM LOCAL WHERE codigo_local=" + codigo_tbx.Text, conexion.Conectar());
                flag = cmd2.ExecuteNonQuery();
                string consulta = "SELECT codigo_local AS 'Codigo de local', nombre AS 'Nombre del local'" +
                " FROM LOCAL ORDER BY codigo_local ASC";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvLocales.DataSource = tabla;
                dgvLocales.DataSource = tabla;
                if (flag == 1)
                {
                    MessageBox.Show("Se elimino correctamente");
                    codigo_tbx.Clear();
                }
                else
                {
                    MessageBox.Show("No existe local con ese codigo");
                    codigo_tbx.Clear();
                }
            }
            catch
            {
                MessageBox.Show("No se puede ingresar letras al campo de codigo");
                codigo_tbx.Clear();
            }
        }
    }
}
