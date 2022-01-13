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
    public partial class VerLocalesForm : Form
    {
        public VerLocalesForm()
        {
            InitializeComponent();
        }
        Clases.Conexion conexion = new Clases.Conexion();        
        private void VerLocalesForm_Load(object sender, EventArgs e)
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
    }
}
