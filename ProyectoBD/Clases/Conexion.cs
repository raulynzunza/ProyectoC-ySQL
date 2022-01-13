using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace ProyectoBD.Clases
{
    class Conexion
    {
        //Este metodo sirve para hacer la conexion con la base de datos
        public SqlConnection Conectar()
        {
            
                SqlConnection conexion = new SqlConnection("SERVER=LAPTOP-P3LRC93A;DATABASE=ProyectoTransporte;Integrated security=true");
                conexion.Open();
                return conexion;
        }

       
    }
}
