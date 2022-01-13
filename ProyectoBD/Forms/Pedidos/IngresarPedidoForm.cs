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
    public partial class IngresarPedidoForm : Form
    {
        public IngresarPedidoForm()
        {
            InitializeComponent();
        }
        metodosPedidos metodo = new metodosPedidos();
        Clases.Conexion conexion = new Clases.Conexion();
        private void IngresarPedidoForm_Load(object sender, EventArgs e)
        {
            codigoCliente_cbx.DataSource = metodo.CargarCombo("CLIENTE", "codigo_cliente");
            codigoCliente_cbx.DisplayMember = "codigo_cliente";
            codigoCliente_cbx.ValueMember = "codigo_cliente";
            codigoTransporte_cbx.DataSource = metodo.CargarCombo("TRANSPORTE", "cod_trans");
            codigoTransporte_cbx.DisplayMember = "cod_trans";
            codigoTransporte_cbx.ValueMember = "cod_trans";
            codigoArticulo_cbx.DataSource = metodo.CargarCombo("ARTICULO", "codigo_art");
            codigoArticulo_cbx.DisplayMember = "codigo_art";
            codigoArticulo_cbx.ValueMember = "codigo_art";
            Random numero = new Random();
            int var = numero.Next(10000, 99999);
            codigo_tbx.Text = Convert.ToString(var);
            string consulta = "SELECT * FROM VISTA3";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Conectar());
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvPedidos.DataSource = tabla;

            this.dgvPedidos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvPedidos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvPedidos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvPedidos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        
        private void agregar_btn_Click(object sender, EventArgs e)
        {
            if (codigoCliente_cbx == null || codigoTransporte_cbx == null || codigoArticulo_cbx == null || codigo_tbx == null)
            {
                MessageBox.Show("No se pueden ingresar valores nulos");
            }
            if (codigoCliente_cbx != null && codigoTransporte_cbx != null && codigoArticulo_cbx != null && codigo_tbx != null)
            {
                try
                {
                    if (metodo.articuloRegistrado(Convert.ToInt32(codigo_tbx.Text), "PEDIDO") == 0)
                    {
                        try
                        {
                            metodo.Insertar(Convert.ToInt32(codigo_tbx.Text), Convert.ToInt32(codigoCliente_cbx.Text), Convert.ToInt32(codigoTransporte_cbx.Text), Convert.ToInt32(codigoArticulo_cbx.Text), fecha_dt.Value.Date.ToString("yyy-MM-dd"),Convert.ToInt32(cantidad_tbx.Text));
                            cantidad_tbx.Clear();
                            MessageBox.Show("Pedido agregado correctamente");
                        }
                        catch
                        {
                            MessageBox.Show("No se pueden ingresar letras en el campo de precio");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("No se pueden ingresar letras en el campo de codigo");
                }

            }
            string consulta = "SELECT * FROM VISTA3";
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
