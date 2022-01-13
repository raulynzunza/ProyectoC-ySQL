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
    public partial class EliminarTransporteForm : Form
    {
        public EliminarTransporteForm()
        {
            InitializeComponent();
        }
        metodosTransporte metodo = new metodosTransporte();
        Clases.Conexion conexion = new Clases.Conexion();
        private void EliminarTransporteForm_Load(object sender, EventArgs e)
        {
            codigo_cbx.DataSource = metodo.CargarCombo("TRANSPORTE", "cod_trans");
            codigo_cbx.DisplayMember = "cod_trans";
            codigo_cbx.ValueMember = "cod_trans";
            string consulta = "SELECT * FROM VISTA1";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvTransporte.DataSource = tabla;

            this.dgvTransporte.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvTransporte.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvTransporte.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                SqlCommand cmd2 = new SqlCommand("DELETE FROM TRANSPORTE WHERE cod_trans=" + codigo_cbx.SelectedValue, conexion.Conectar());
                flag = cmd2.ExecuteNonQuery(); //Positivo = 1 | negativo = 0
                //Esta parte de codigo sirve para que se refresque el datagrid automaticamente
                string consulta = "SELECT * FROM VISTA1";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvTransporte.DataSource = tabla;
                dgvTransporte.DataSource = tabla;
                if (flag == 1)
                {
                    MessageBox.Show("Se elimino correctamente");                    
                }
                else
                {
                    MessageBox.Show("No existe cliente con ese codigo");                    
                }
            }
            catch
            {
                MessageBox.Show("No se puede ingresar letras al campo de codigo");               
            }
        }
    }
}
