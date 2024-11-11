using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms.Entidades
{
    internal class Logica_Bancos
    {
        public class LogicaBanco
        {
            private List<Bancos> cuentasBancarias;

            public LogicaBanco()
            {
                cuentasBancarias = new List<Bancos>();
            }

            // Método para agregar una cuenta bancaria
            public void AgregarCuenta(Bancos cuenta)
            {
                cuentasBancarias.Add(cuenta);
            }

            // Método para verificar si un cliente tiene fondos suficientes
            public bool VerificarFondos(int idCuenta, decimal monto)
            {
                var cuenta = cuentasBancarias.FirstOrDefault(c => c.Id == idCuenta);
                if (cuenta != null)
                {
                    return cuenta.Saldo >= monto;
                }
                return false;
            }

            // Método para realizar una compra
            public bool RealizarCompra(int idCuentaCliente, decimal montoCompra)
            {
                var cuentaCliente = cuentasBancarias.FirstOrDefault(c => c.Id == idCuentaCliente);
                if (cuentaCliente != null && cuentaCliente.Extraer(montoCompra))
                {
                    return true; // Compra exitosa
                }
                return false; // Fondos insuficientes
            }

            // Método para transferir dinero entre cuentas (por ejemplo, empresa a proveedor)
            public bool TransferirFondos(int idCuentaOrigen, int idCuentaDestino, decimal monto)
            {
                var cuentaOrigen = cuentasBancarias.FirstOrDefault(c => c.Id == idCuentaOrigen);
                var cuentaDestino = cuentasBancarias.FirstOrDefault(c => c.Id == idCuentaDestino);

                if (cuentaOrigen != null && cuentaDestino != null && cuentaOrigen.Extraer(monto))
                {
                    cuentaDestino.Depositar(monto);
                    return true;
                }
                return false; // Transferencia fallida
            }
        }
    }
}


