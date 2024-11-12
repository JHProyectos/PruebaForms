using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using PruebaForms.Entidades;

namespace PruebaForms.Lógica
{
    internal class Logica_Bancos
    {
        public class LogicaBanco
        {
            private List<Bancos> cuentasBancarias;

            public LogicaBanco()
            {
                cuentasBancarias = new List<Bancos>();
                CargarCuentasBancarias();
            }

            private void CargarCuentasBancarias()
            {
                // Load data from datosClientes.xml
                string archivoClientesXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "datosClientes.xml");
                if (File.Exists(archivoClientesXml))
                {
                    XDocument docClientes = XDocument.Load(archivoClientesXml);
                    cuentasBancarias.AddRange(
                        docClientes.Descendants("Clientes")
                            .Select(c => new Bancos(
                                c.Element("CuentaBancariaID").Value,
                                $"{c.Element("Nombre").Value} {c.Element("Apellido").Value}",
                                decimal.Parse(c.Element("Saldo").Value),
                                "Cliente"
                            ))
                    );
                }

                // Load data from datosProveedores.xml
                string archivoProveedoresXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "datosProveedores.xml");
                if (File.Exists(archivoProveedoresXml))
                {
                    XDocument docProveedores = XDocument.Load(archivoProveedoresXml);
                    cuentasBancarias.AddRange(
                        docProveedores.Descendants("Proveedores")
                            .Select(c => new Bancos(
                                c.Element("CuentaBancariaID").Value,
                                $"{c.Element("Nombre").Value} {c.Element("Apellido").Value}",
                                decimal.Parse(c.Element("Saldo").Value),
                                "Proveedor"
                            ))
                    );
                }
            }

            public void AgregarCuenta(Bancos cuenta)
            {
                cuentasBancarias.Add(cuenta);
            }

            public bool VerificarFondos(string cuentaBancariaID, decimal monto)
            {
                var cuenta = cuentasBancarias.FirstOrDefault(c => c.CuentaBancariaID == cuentaBancariaID);
                return cuenta != null && cuenta.Saldo >= monto;
            }

            public bool RealizarCompra(string cuentaBancariaID, decimal montoCompra)
            {
                var cuentaCliente = cuentasBancarias.FirstOrDefault(c => c.CuentaBancariaID == cuentaBancariaID);
                if (cuentaCliente != null && cuentaCliente.Extraer(montoCompra))
                {
                    return true; // Successful purchase
                }
                return false; // Insufficient funds
            }

            public bool TransferirFondos(string cuentaOrigenID, string cuentaDestinoID, decimal monto)
            {
                var cuentaOrigen = cuentasBancarias.FirstOrDefault(c => c.CuentaBancariaID == cuentaOrigenID);
                var cuentaDestino = cuentasBancarias.FirstOrDefault(c => c.CuentaBancariaID == cuentaDestinoID);

                if (cuentaOrigen != null && cuentaDestino != null && cuentaOrigen.Extraer(monto))
                {
                    cuentaDestino.Depositar(monto);
                    return true;
                }
                return false; // Transfer failed
            }
        }
    }
}
