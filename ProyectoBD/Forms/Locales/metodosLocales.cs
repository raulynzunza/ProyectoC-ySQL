using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoBD.Forms.Locales
{
    class metodosLocales
    {
        Clases.Conexion conexion = new Clases.Conexion();

        public void Insertar(int codigo, string nombre, string direccion)
        {                        
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO LOCAL (codigo_local,direccion,nombre) " +
                    "VALUES(" + codigo + ",'" + direccion + "','" + nombre + "')", conexion.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }

        }

        public void Modificar(int codigo, string direccion, string nombre)
        {
            if (articuloRegistrado(codigo, "LOCAL") > 0)
            {
                SqlCommand cmd2 = new SqlCommand("MOD_LOCAL", conexion.Conectar());
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@nombre", nombre);
                cmd2.Parameters.AddWithValue("@codigo_local", codigo);
                cmd2.Parameters.AddWithValue("@direccion", direccion);                
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + tabla + " WHERE codigo_local=" + codigo + "", conexion.Conectar());
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
    }
}
