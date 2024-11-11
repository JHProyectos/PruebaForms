using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms.Entidades
{   
    internal class Proveedores
    {
        private int idProveedor;
        private string nombrePro;
        private string apellidoPro;
        private string emailPro;
        private string telefonoPro;

        public Proveedores()
        {
        }

        public Proveedores(int idProveedor, string nombrePro, string apellidoPro, string emailPro, string telefonoPro)
        {
            this.idProveedor = idProveedor;
            this.nombrePro = nombrePro;
            this.apellidoPro = apellidoPro;
            this.emailPro = emailPro;
            this.telefonoPro = telefonoPro;
        }

        private int getidProveedor()
        {
            return idProveedor;
        }
        private string getnombrePro()
        {
            return nombrePro;
        }
        private string getapellidoPro()
        {
            return apellidoPro;
        }
        private string getemailPro()
        {
            return emailPro;
        }
        private string gettelefonoPro()
        {
            return telefonoPro;
        }

        private void setidProveedor(int idProveedor)
        {
            this.idProveedor = idProveedor;
        }
        private void setnombrePro(string nombrePro)
        {
            this.nombrePro = nombrePro;
        }
        private void setapellidoPro(string apellidoPro)
        {
            this.apellidoPro = apellidoPro;
        }

        private void setemailPro(string emailPro)
        {
            this.emailPro = emailPro;
        }
        private void settelefonoPro(string telefonoPro)
        {
            this.telefonoPro = telefonoPro;
        }

    }
}
