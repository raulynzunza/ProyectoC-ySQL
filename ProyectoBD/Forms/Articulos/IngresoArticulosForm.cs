using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoBD
{
    public partial class IngresoArticulos : Form
    {

        public IngresoArticulos()
        {
            InitializeComponent();
        }

        Clases.Conexion conexion = new Clases.Conexion();
        Clases.Metodos insertar = new Clases.Metodos();       
        
        private void agregarArt_btn_Click(object sender, EventArgs e)
        {
            if (nombre_tbx == null || precio_tbx == null || codigo_tbx == null || descripcion_tbx == null)
            {
                MessageBox.Show("No se pueden ingresar valores nulos");
            }
            if (nombre_tbx != null && precio_tbx != null && codigo_tbx != null && descripcion_tbx != null)
            {
                try
                {
                    if (articuloRegistrado(Convert.ToInt32(codigo_tbx.Text)) == 0)
                    {
                        try
                        {
                            insertar.Insertar(nombre_tbx.Text, Convert.ToDouble(precio_tbx.Text), Convert.ToInt32(codigo_tbx.Text), descripcion_tbx.Text,Convert.ToInt32(cantidad_tbx.Text),"ARTICULO");
                            nombre_tbx.Clear();
                            precio_tbx.Clear();
                            codigo_tbx.Clear();
                            descripcion_tbx.Clear();
                            cantidad_tbx.Clear();
                            MessageBox.Show("Articulo agregado correctamente");
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
            
        }

        
        //Este metodo sirvio para saber si algun articulo ya estaba registrado
        public int articuloRegistrado(int codigo)
        {
            int contador = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ARTICULO WHERE codigo_art=" + codigo + "", conexion.Conectar());
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

        private void IngresoArticulos_Load(object sender, EventArgs e)
        {            
            Random numero = new Random();
            int var= numero.Next(1000, 9999);                                   
            codigo_tbx.Text = Convert.ToString(var);            
        }
    }
}
