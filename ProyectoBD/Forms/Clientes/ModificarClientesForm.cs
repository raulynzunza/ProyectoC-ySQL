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
    public partial class ModificarClientesForm : Form
    {
        public ModificarClientesForm()
        {
            InitializeComponent();
        }

        metodosClientes metodo = new metodosClientes();
        Clases.Conexion conexion = new Clases.Conexion();
        
        private void modificar_btn_Click(object sender, EventArgs e)
        {
            if (codigo_tbx != null && nombre_tbx != null && apellidoPaterno_tbx != null && apellidoMaterno_tbx != null && direccion_tbx != null && telefono_tbx != null && correo_tbx != null)
            {
                try
                {
                    metodo.Modificar(Convert.ToInt32(codigo_tbx.Text),direccion_tbx.Text,nombre_tbx.Text,apellidoPaterno_tbx.Text,apellidoMaterno_tbx.Text,correo_tbx.Text,telefono_tbx.Text);
                    string consulta = "SELECT codigo_cliente AS 'Codigo de cliente', nombre AS 'Nombre de cliente',apellido_P AS 'Apellido paterno'" +
                ", apellido_M AS 'Apellido materno' FROM CLIENTE ORDER BY codigo_cliente ASC";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvClientes.DataSource = tabla;
                    nombre_tbx.Clear();
                    codigo_tbx.Clear();
                    apellidoPaterno_tbx.Clear();
                    apellidoMaterno_tbx.Clear();
                    direccion_tbx.Clear();
                    telefono_tbx.Clear();
                    correo_tbx.Clear();
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

        private void ModificarClientesForm_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT codigo_cliente AS 'Codigo de cliente', nombre AS 'Nombre de cliente',apellido_P AS 'Apellido paterno'" +
                ", apellido_M AS 'Apellido materno' FROM CLIENTE ORDER BY codigo_cliente ASC";
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
