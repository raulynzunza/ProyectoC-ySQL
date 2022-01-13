using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoBD.Forms
{
    public partial class ModificarArtForm : Form
    {        
        Clases.Metodos metodo = new Clases.Metodos();
        Clases.Conexion conexion = new Clases.Conexion();
        public ModificarArtForm()
        {
            InitializeComponent();
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            if (nombre_tbx != null && precio_tbx != null && codigo_tbx != null && descripcion_tbx != null)
            {
               try
                 {
                    
                    metodo.Modificar(nombre_tbx.Text, Convert.ToDouble(precio_tbx.Text), Convert.ToInt32(codigo_tbx.Text), descripcion_tbx.Text,Convert.ToInt32(cantidad_tbx.Text), "ARTICULO");
                    string consulta = "SELECT codigo_art AS 'Codigo de articulo',nombre AS 'Nombre de articulo',precio AS 'Precio' FROM ARTICULO ORDER BY codigo_art ASC";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    this.dgvArticulos.DataSource = tabla;
                    nombre_tbx.Clear();
                    precio_tbx.Clear();
                    codigo_tbx.Clear();
                    descripcion_tbx.Clear();
                    cantidad_tbx.Clear();
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

        private void ModificarArtForm_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT codigo_art AS 'Codigo de articulo',nombre AS 'Nombre de articulo',precio AS 'Precio' FROM ARTICULO ORDER BY codigo_art ASC";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvArticulos.DataSource = tabla;

            this.dgvArticulos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvArticulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvArticulos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
    }
}
