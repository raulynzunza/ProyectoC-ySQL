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

namespace ProyectoBD
{
    public partial class verArt : Form
    {
        public verArt()
        {
            InitializeComponent();
        }

        Clases.Conexion conexion = new Clases.Conexion();

        //Este metodo sirve para la visualizacion de la tabla de articulos de la base de datos
        private void verArt_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT nombre AS 'Nombre de articulo',precio AS 'Precio',codigo_art AS 'Codigo de articulo', descripcion AS 'Descripcion del articulo',cantidad AS 'Cantidad' FROM ARTICULO ORDER BY codigo_art ASC";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta,conexion.Conectar());
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvArticulos.DataSource = tabla;
            
            this.dgvArticulos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvArticulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvArticulos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvArticulos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
