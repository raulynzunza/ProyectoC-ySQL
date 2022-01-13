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

namespace ProyectoBD.Forms.Clientes
{
    public partial class EliminarClientesForm : Form
    {
        public EliminarClientesForm()
        {
            InitializeComponent();
        }
        Clases.Conexion conexion = new Clases.Conexion();
        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                SqlCommand cmd2 = new SqlCommand("DELETE FROM CLIENTE WHERE codigo_cliente=" + codigo_tbx.Text, conexion.Conectar());
                flag = cmd2.ExecuteNonQuery(); //Positivo = 1 | negativo = 0
                //Esta parte de codigo sirve para que se refresque el datagrid automaticamente
                string consulta = "SELECT codigo_cliente AS 'Codigo de cliente', nombre AS 'Nombre de cliente',apellido_P AS 'Apellido paterno'" +
                ", apellido_M AS 'Apellido materno', direccion AS 'Direccion', telefono AS 'Telefono',correo AS'Correo electronico' FROM CLIENTE ORDER BY codigo_cliente ASC";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes.DataSource = tabla;
                dgvClientes.DataSource = tabla;
                if (flag == 1)
                {
                    MessageBox.Show("Se elimino correctamente");
                    codigo_tbx.Clear();
                }
                else
                {
                    MessageBox.Show("No existe cliente con ese codigo");
                    codigo_tbx.Clear();
                }
            }
            catch
            {
                MessageBox.Show("No se puede ingresar letras al campo de codigo");
                codigo_tbx.Clear();
            }
        }

        private void EliminarClientesForm_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT codigo_cliente AS 'Codigo de cliente', nombre AS 'Nombre de cliente',apellido_P AS 'Apellido paterno'" +
                ", apellido_M AS 'Apellido materno', direccion AS 'Direccion', telefono AS 'Telefono',correo AS'Correo electronico' FROM CLIENTE ORDER BY codigo_cliente ASC";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes.DataSource = tabla;

            this.dgvClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
