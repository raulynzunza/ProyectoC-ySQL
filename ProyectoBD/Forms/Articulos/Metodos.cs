using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoBD.Clases
{
    class Metodos
    {
        Conexion conexion = new Conexion();
        //Este metodo lo que hace es mandar la instruccion de insert al metodo de la clase de conexion
        public void Insertar(string nombre, double precio, int codigo, string descripcion, int cantidad,string tabla)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO "+tabla+" (nombre,precio,codigo_art,descripcion,cantidad) " +
                    "VALUES('" + nombre + "'," + precio + "," + codigo + ",'" + descripcion + "',"+cantidad+")", conexion.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }

        }
        public void Modificar(string nombre, double precio, int codigo, string descripcion,int cantidad,string tabla)
        {
            if (articuloRegistrado(codigo, tabla) > 0)
            {
                SqlCommand cmd2 = new SqlCommand("MOD_ART", conexion.Conectar());
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@nombre",nombre);
                cmd2.Parameters.AddWithValue("@precio", precio);
                cmd2.Parameters.AddWithValue("@cantidad", cantidad);
                cmd2.Parameters.AddWithValue("@descripcion", descripcion);
                cmd2.Parameters.AddWithValue("@codigo_art", codigo);
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

        public int articuloRegistrado(int codigo,string tabla)//Metodo para ver si ya hay un articulo con ese codigo
        {
            int contador = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM "+tabla+ " WHERE codigo_art="+codigo+"", conexion.Conectar());
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
