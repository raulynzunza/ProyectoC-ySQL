using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoBD.Forms.Clientes
{
    class metodosClientes
    {
        Clases.Conexion conexion = new Clases.Conexion();
        
        public void Insertar(int codigo,string nombre, string apellidoPaterno,string apellidoMaterno, string direccion, string telefono, string email)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTE (codigo_cliente,nombre,apellido_P,apellido_M,direccion,telefono,correo) " +
                    "VALUES(" + codigo + ",'" + nombre + "','" + apellidoPaterno + "','" + apellidoMaterno + "','" + direccion + "','"+telefono+"','"+email+"')", 
                    conexion.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }

        }
        
        public void Modificar(int codigo, string direccion, string nombre, string apellidoP, string apellidoM, String correo, string telefono)
        {
            if (articuloRegistrado(codigo,"CLIENTE") > 0)
            {
                SqlCommand cmd2 = new SqlCommand("MOD_CLI", conexion.Conectar());
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@nombre", nombre);
                cmd2.Parameters.AddWithValue("@apellidoP", apellidoP);
                cmd2.Parameters.AddWithValue("@apellidoM", apellidoM);
                cmd2.Parameters.AddWithValue("@codigo_cliente", codigo);
                cmd2.Parameters.AddWithValue("@direccion", direccion);
                cmd2.Parameters.AddWithValue("@telefono", telefono);
                cmd2.Parameters.AddWithValue("@correo", correo);
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM "+tabla+" WHERE codigo_cliente=" + codigo + "", conexion.Conectar());
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
