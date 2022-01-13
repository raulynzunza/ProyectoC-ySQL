using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoBD.Forms.Transporte
{
    class metodosTransporte
    {
        Clases.Conexion conexion = new Clases.Conexion();

        public void Insertar(string nombre, string apellidoP, string apellidoM, int codigoTransporte, int codigoLocal)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TRANSPORTE (nombre_cond,apellidoP_cond,apellidoM_cond,cod_trans,codigo_local) " +
                    "VALUES('" + nombre + "','" + apellidoP + "','" + apellidoM + "',"+codigoTransporte+","+codigoLocal+")", conexion.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }

        }
        
        public void Modificar(string nombre, string apellidoP, string apellidoM, int codigoTransporte,int codigoLocal)
        {
            if (articuloRegistrado(codigoTransporte, "TRANSPORTE") > 0)
            {
                SqlCommand cmd2 = new SqlCommand("MOD_TRANSPORTE", conexion.Conectar());
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@nombre_cond", nombre);
                cmd2.Parameters.AddWithValue("@apellidoP_cond", apellidoP);
                cmd2.Parameters.AddWithValue("@apellidoM_cond", apellidoM);
                cmd2.Parameters.AddWithValue("@cod_trans", codigoTransporte);
                cmd2.Parameters.AddWithValue("@codigo_local", codigoLocal);
                
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + tabla + " WHERE cod_trans=" + codigo + "", conexion.Conectar());
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

        public DataTable CargarCombo(string tabla,string valores)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT "+valores+" FROM "+tabla,conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
