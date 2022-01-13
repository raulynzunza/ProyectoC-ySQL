using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoBD.Forms.Pedidos
{
    class metodosPedidos
    {
        Clases.Conexion conexion = new Clases.Conexion();
        
        public void Insertar(int codigoPedido, int codigoCliente, int codigoTransporte, int codigoArticulo, string fecha,int cantidad)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO PEDIDO (ped_codigo,codigo_cliente,cod_trans,codigo_art,fecha,cantidad) " +
                    "VALUES(" + codigoPedido + "," + codigoCliente + "," + codigoTransporte + "," + codigoArticulo + ",'" + fecha + "',"+cantidad+")", conexion.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }

        }
        
        public void Modificar(int codigoPedido, int codigoCliente, int codigoTrans, int codigoArt, string fecha, int cantidad)
        {
            if (articuloRegistrado(codigoPedido, "PEDIDO") > 0)
            {
                SqlCommand cmd2 = new SqlCommand("MOD_PEDIDO", conexion.Conectar());
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@ped_codigo", codigoPedido);
                cmd2.Parameters.AddWithValue("@codigo_cliente", codigoCliente);
                cmd2.Parameters.AddWithValue("@cod_trans", codigoTrans);
                cmd2.Parameters.AddWithValue("@codigo_art", codigoArt);
                cmd2.Parameters.AddWithValue("@fecha", fecha);
                cmd2.Parameters.AddWithValue("@cantidad", cantidad);

                try
                {
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Modificado correctamente");
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
            else
            {
                MessageBox.Show("No existe ese codigo");
            }

        }
        public int articuloRegistrado(int codigo, string tabla)//Metodo para ver si ya hay un articulo con ese codigo
        {
            int contador = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + tabla + " WHERE ped_codigo=" + codigo + "", conexion.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
            }
            catch (Exception ex)
            {

            }
            return contador;
        }

        public DataTable CargarCombo(string tabla, string valores)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT " + valores + " FROM " + tabla, conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
