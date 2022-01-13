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

namespace ProyectoBD.Forms.Pedidos
{
    public partial class VerPedidoForm : Form
    {
        public VerPedidoForm()
        {
            InitializeComponent();
        }
        Clases.Conexion conexion = new Clases.Conexion();
        private void VerPedidoForm_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM VISTA5";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvPedidos.DataSource = tabla;

            this.dgvPedidos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvPedidos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvPedidos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvPedidos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
