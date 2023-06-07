using ejercicio_POO.modelos;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO.dao
{
    

    internal class ClienteDao
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "clientes";

            string cadenaConexion = "server=" + servidor + ";uid=" + usuario + ";pwd=" + password + ";database=" + baseDeDatos;


            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(cadenaConexion);
            conn.Open();
            return conn;   
           
        }

        public List<Cliente> ObtenerListadoDeClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                string consulta = "SELECT * FROM `clientes`";
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = Conectar();

                MySqlDataReader lectura = cmd.ExecuteReader();

                while (lectura.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = lectura.GetString("id");
                    cliente.Nombre = lectura.GetString("nombre");
                    cliente.Apellido = lectura.GetString("apellido");
                    cliente.Telefono = lectura.GetString("telefono");    
                    cliente.TarjetaDeCredito = lectura.GetString("tarjeta_de_credito");    
                    lista.Add(cliente);
                }
                cmd.Connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    

            }


            return lista;

        }

        public void Guardar(Cliente cliente)
        {
            if(cliente.Id == null)
            {
                insetar(cliente);
            }
            else
            {
                actualizar(cliente);
            }

        }


        private void insetar (Cliente cliente)
        {
            string consulta = "INSERT INTO `clientes` (`id`,`nombre`,`apellido`,`telefono`,`tarjeta_de_credito`) VALUES (NULL,'" + cliente.Nombre + "','" + cliente.Apellido + "','" + cliente.Telefono + "','" + cliente.TarjetaDeCredito + "');";
            MySqlCommand cmd = new MySqlCommand(consulta);
            cmd.Connection = Conectar();
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();

        }

        private void actualizar(Cliente cliente)
        {
            string consulta = "UPDATE `clientes` SET `nombre` = '"+cliente.Nombre+"', `apellido` = '"+cliente.Apellido+"', `telefono` = '"+cliente.Telefono+"', `tarjeta_de_credito` = '"+cliente.TarjetaDeCredito+"' WHERE `clientes`.`id` = "+cliente.Id+";";
            MySqlCommand cmd = new MySqlCommand(consulta);
            cmd.Connection = Conectar();
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();

        }


        public void Eliminar(Cliente cliente)
        {
            string consulta = "DELETE FROM clientes WHERE `clientes`.`id` = "+cliente.Id+";";
            MySqlCommand cmd = new MySqlCommand(consulta);
            cmd.Connection = Conectar();
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();

        }

    }
}
 