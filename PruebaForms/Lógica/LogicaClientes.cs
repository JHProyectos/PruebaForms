using PruebaForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace PruebaForms.Lógica
{
    internal class LogicaClientes
    {
            private List<Clientes> clientes;
            private readonly string archivoXml = @"D:\Documentos\Jonatan\Facultad\Sistemas\2do_Año\Paradigmas\POO\PruebaForms\PruebaForms\Repositorio\datosClientes.xml";


        public LogicaClientes()
            {
                clientes = CargarClientes(); // Cargar los clientes desde el archivo XML al iniciar
            }            

            // Método para cargar la lista de clientes desde el archivo XML
          
            public List<Clientes> ObtenerClientes()
            {

                return clientes ?? new List<Clientes>();
            }
        public void AgregarCliente(Clientes nuevoCliente)
        {
            clientes.Add(nuevoCliente);
            GuardarClientes(clientes);
        }

        // Método para guardar la lista de clientes en el archivo XML
        public void GuardarClientes(List<Clientes> clientes)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Clientes>));
                using (StreamWriter writer = new StreamWriter(archivoXml))
                {
                    serializer.Serialize(writer, clientes);
                }
            }

            public List<Clientes> CargarClientes()
            {
                if (File.Exists(archivoXml))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Clientes>));
                    using (StreamReader reader = new StreamReader(archivoXml))
                    {
                        try
                        {
                            var listaClientes = (List<Clientes>)serializer.Deserialize(reader);
                         //   MessageBox.Show($"Clientes cargados: {listaClientes.Count}");
                            return listaClientes;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cargar clientes: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo XML no se encontró.");
                }

                return new List<Clientes>(); // Retorna una lista vacía si hay algún problema
            }

           
            // Método para eliminar un cliente
            public void EliminarCliente(Clientes clienteAEliminar)
            {
                clientes.Remove(clienteAEliminar); // Eliminar el cliente de la lista
                GuardarClientes(clientes);  // Guardar los cambios en el archivo XML
            //    OnClientesChanged();
            }

          


        // Obtener un resumen de cuenta del cliente (puedes personalizar este método)
        public string ObtenerResumenCuenta(Clientes cliente)
            {
                return $"Resumen de cuenta de {cliente.Nombre} {cliente.Apellido}:\n\n" +
                       $"DNI: {cliente.DNI}\n" +
                       $"CUIT: {cliente.CUIT}\n" +
                       $"Teléfono: {cliente.Telefono}\n" +
                       $"Dirección: {cliente.Direccion}\n" +
                       $"Email: {cliente.Email}";
            }
        }
    }
