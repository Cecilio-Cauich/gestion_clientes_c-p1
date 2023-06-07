using ejercicio_POO.dao;
using ejercicio_POO.modelos;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_POO
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();

        }

        private void actualizarLista()
        {
            ClienteDao baseDatos = new ClienteDao();
            List<Cliente> listadb = baseDatos.ObtenerListadoDeClientes();
            listClients.Items.Clear();

            for (int i = 0; i < listadb.Count; i++)
            {
                Cliente cliente = listadb[i];
                listClients.Items.Add(cliente);
            }

        }

        private void listClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            modelos.Cliente cliente = new modelos.Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.TarjetaDeCredito = txtTarjetaCredito.Text;
            cliente.Telefono = txtTelefono.Text;

            if(lblID.Text !="")
            {
                cliente.Id = lblID.Text;
            }

            ClienteDao baseDatos = new ClienteDao();
            baseDatos.Guardar(cliente);
            actualizarLista();

            //listClients.Items.Add(cliente);

            txtNombre.ResetText();
            txtApellido.ResetText();
            txtTarjetaCredito.ResetText();
            txtTelefono.ResetText();

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClients.SelectedItem;

            ClienteDao baseDatos = new ClienteDao();
            baseDatos.Eliminar(cliente);
            actualizarLista();

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClients.SelectedItem;

            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtTarjetaCredito.Text = cliente.TarjetaDeCredito;
            lblID.Text = cliente.Id;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {   
            lblID.ResetText();
            txtNombre.ResetText();
            txtApellido.ResetText();
            txtTarjetaCredito.ResetText();
            txtTelefono.ResetText();

        }
    }
}
