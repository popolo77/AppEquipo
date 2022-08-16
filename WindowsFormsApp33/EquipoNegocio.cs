using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp33
{
   class EquipoNegocio
    {
        public List<Perfil> NegocioList() { 
            List<Perfil> lista = new List<Perfil>();
            SqlConnection conection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conection.ConnectionString = "server= .\\SQLEXPRESS; database=EQUIPO_DB; integrated security=true ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select Dorsal, Nombre, Apellido, Posicion, Fecha_Nacimiento, Url_Imagen from Perfil1";
                cmd.Connection = conection;

                conection.Open();

                lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    Perfil aux = new Perfil();
                    aux.Dorsal = (string)lector[0];
                    aux.Nombre =(string)lector[1];
                    aux.Apellido=(string)lector[2]; 
                    aux.Posicion= (string)lector[3];
                    aux.Fecha_Nacimiento= (DateTime)lector[4];
                    aux.Url_Imagen = (string)lector[5];

                    lista.Add(aux);
                
                
                }
                conection.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }





            
        
        
        }


    }
}
