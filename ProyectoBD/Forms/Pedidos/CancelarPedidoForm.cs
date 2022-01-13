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
    public partial class CancelarPedidoForm : Form
    {
        public CancelarPedidoForm()
        {
            InitializeComponent();
        }
        metodosPedidos metodo = new metodosPedidos();
        Clases.Conexion conexion = new Clases.Conexion();
        private void CancelarPedidoForm_Load(object sender, EventArgs e)
        {
            codigo_cbx.DataSource = metodo.CargarCombo("PEDIDO", "ped_codigo");
            codigo_cbx.DisplayMember = "ped_codigo";
            codigo_cbx.ValueMember = "ped_codigo";
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

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                SqlCommand cmd2 = new SqlCommand("DELETE FROM PEDIDO WHERE ped_codigo=" + codigo_cbx.SelectedValue, conexion.Conectar());
                flag = cmd2.ExecuteNonQuery(); //Positivo = 1 | negativo = 0
                //Esta parte de codigo sirve para que se refresque el datagrid automaticamente
                string consulta = "SELECT * FROM VISTA5";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvPedidos.DataSource = tabla;
                dgvPedidos.DataSource = tabla;
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
