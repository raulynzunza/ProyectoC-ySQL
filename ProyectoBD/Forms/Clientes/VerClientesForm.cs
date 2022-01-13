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
    public partial class VerClientesForm : Form
    {
        public VerClientesForm()
        {
            InitializeComponent();
        }

        Clases.Conexion conexion = new Clases.Conexion();
        

        private void VerClientesForm_Load(object sender, EventArgs e)
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
