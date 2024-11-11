using PruebaForms.Lógica;
using PruebaForms.Entidades;
using System;
using System.Windows.Forms;

namespace PruebaForms.Interfaz
{
    public partial class FormularioNuevoCliente : Form
    {
        private LogicaClientes logicaClientes;

        public FormularioNuevoCliente()
        {
            InitializeComponent();
            logicaClientes = new LogicaClientes();
        }

        private void FNC_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que no haya campos vacíos
                if (string.IsNullOrWhiteSpace(FNC_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(FNC_Apellido.Text) ||
                    string.IsNullOrWhiteSpace(FNC_DNI.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                // Crear un nuevo cliente
                Clientes nuevoCliente = new Clientes
                {
                    Nombre = FNC_Nombre.Text,
                    Apellido = FNC_Apellido.Text,
                    DNI = FNC_DNI.Text,
                    CUIT = FNC_CUIT.Text,
                    Telefono = FNC_Telefono.Text,
                    Direccion = FNC_Direccion.Text,
                    Email = FNC_Email.Text,
                    CuentaBancariaID = FNC_CuentaBancaria.Text
                };

                // Add the new client using the LogicaClientes method
                logicaClientes.AgregarCliente(nuevoCliente);

                // Clear the form fields
                LimpiarCampos();

                // Show success message
                MessageBox.Show("Cliente agregado exitosamente.");

                // Close the form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cliente: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private void LimpiarCampos()
        {
            FNC_Nombre.Clear();
            FNC_Apellido.Clear();
            FNC_DNI.Clear();
            FNC_CUIT.Clear();
            FNC_Telefono.Clear();
            FNC_Direccion.Clear();
            FNC_Email.Clear();
            FNC_CuentaBancaria.Clear();
        }

        private void FNC_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    

// Ruta del archivo XML
//string archivoXml = @"D:\Documentos\Jonatan\Facultad\Sistemas\2do_Año\Paradigmas\POO\PruebaForms\PruebaForms\Repositorio\datosClientes.xml";
        

      
        // Evento para cancelar la operación y cerrar el formulario
       
    }
}
