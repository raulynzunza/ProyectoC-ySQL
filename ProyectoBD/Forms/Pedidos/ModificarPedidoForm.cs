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
    public partial class ModificarPedidoForm : Form
    {
        public ModificarPedidoForm()
        {
            InitializeComponent();
        }
        metodosPedidos metodo = new metodosPedidos();
        Clases.Conexion conexion = new Clases.Conexion();
        private void ModificarPedidoForm_Load(object sender, EventArgs e)
        {
            codigoPedido_cbx.DataSource = metodo.CargarCombo("PEDIDO", "ped_codigo");
            codigoPedido_cbx.DisplayMember = "ped_codigo";
            codigoPedido_cbx.ValueMember = "ped_codigo";
            codigoCliente_cbx.DataSource = metodo.CargarCombo("CLIENTE", "codigo_cliente");
            codigoCliente_cbx.DisplayMember = "codigo_cliente";
            codigoCliente_cbx.ValueMember = "codigo_cliente";
            codigoTransporte_cbx.DataSource = metodo.CargarCombo("TRANSPORTE", "cod_trans");
            codigoTransporte_cbx.DisplayMember = "cod_trans";
            codigoTransporte_cbx.ValueMember = "cod_trans";
            codigoArticulo_cbx.DataSource = metodo.CargarCombo("ARTICULO", "codigo_art");
            codigoArticulo_cbx.DisplayMember = "codigo_art";
            codigoArticulo_cbx.ValueMember = "codigo_art";
            string consulta = "SELECT * FROM VISTA6";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvPedidos.DataSource = tabla;

            this.dgvPedidos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvPedidos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvPedidos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvPedidos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            if (codigoPedido_cbx != null && codigoArticulo_cbx != null && codigoCliente_cbx != null && codigoTransporte_cbx != null && cantidad_tbx != null)
            {
                try
                {
                    metodo.Modificar(Convert.ToInt32(codigoPedido_cbx.Text), Convert.ToInt32(codigoCliente_cbx.Text), Convert.ToInt32(codigoTransporte_cbx.Text), Convert.ToInt32(codigoArticulo_cbx.Text), fecha.Value.Date.ToString("yyy-MM-dd"),Convert.ToInt32(cantidad_tbx.Text));
                    string consulta = "SELECT * FROM VISTA6";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvPedidos.DataSource = tabla;

                    this.dgvPedidos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.dgvPedidos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.dgvPedidos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.dgvPedidos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
    }
}
