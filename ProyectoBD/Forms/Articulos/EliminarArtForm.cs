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
    public partial class EliminarArtForm : Form
    {
        Clases.Conexion conexion = new Clases.Conexion();
        public EliminarArtForm()
        {
            InitializeComponent();
        }

        //Metodo para eliminar algun valor de la tabla
        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                SqlCommand cmd2 = new SqlCommand("DELETE FROM ARTICULO WHERE codigo_art=" + codigo_tbx.Text, conexion.Conectar());                
                flag = cmd2.ExecuteNonQuery(); //Positivo = 1 | negativo = 0
                //Esta parte de codigo sirve para que se refresque el datagrid automaticamente
                string consulta = "SELECT nombre AS 'Nombre de articulo',precio AS 'Precio',codigo_art AS 'Codigo de articulo', descripcion AS 'Descripcion del articulo' FROM ARTICULO ORDER BY codigo_art ASC";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvArticulos.DataSource = tabla;
                if (flag == 1)
                {
                    MessageBox.Show("Se elimino correctamente");
                    codigo_tbx.Clear();
                }
                else
                {
                    MessageBox.Show("No existe articulo con ese codigo");
                    codigo_tbx.Clear();
                }
            }
            catch 
            {
                MessageBox.Show("No se puede ingresar letras al campo de codigo");
                codigo_tbx.Clear();
            }
            

        }

        private void EliminarArtForm_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT nombre AS 'Nombre de articulo',precio AS 'Precio',codigo_art AS 'Codigo de articulo', descripcion AS 'Descripcion del articulo' FROM ARTICULO ORDER BY codigo_art ASC";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
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
