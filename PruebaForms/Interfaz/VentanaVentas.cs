using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PruebaForms.Interfaz
{
    public partial class VentanaVentas : Form
    {
        public VentanaVentas()
        {
            InitializeComponent();
        }


        private void btnCargarXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml",
                Title = "Selecciona un archivo XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                CargarXmlEnCheckedListBox(rutaArchivo);
            }
        }

        private void CargarXmlEnCheckedListBox(string rutaArchivo)
        {
            // Limpia el contenido previo del CheckedListBox
            checkedListBox1.Items.Clear();

            // Cargar el archivo XML en un XmlDocument
            XmlDocument doc = new XmlDocument();
            doc.Load(rutaArchivo);

            // Seleccionar todos los nodos <Auto> en el XML
            XmlNodeList autos = doc.SelectNodes("//Cliente");

            // Iterar sobre cada nodo <Auto>
            foreach (XmlNode auto in autos)
            {
                // Crear una lista para almacenar los valores de los subnodos
                List<string> items = new List<string>();

                // Obtener todos los subnodos dentro de este nodo <Auto>
                foreach (XmlNode subNodo in auto.ChildNodes)
                {
                    // Agregar el texto del subnodo a la lista
                    items.Add(subNodo.InnerText.Trim());
                }

                // Combinar los valores de los subnodos en una sola cadena, separados por un espacio
                string textoCombinado = string.Join(" ", items);

                // Agregar la cadena combinada como un ítem en el CheckedListBox
                checkedListBox1.Items.Add(textoCombinado);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml",
                Title = "Selecciona un archivo XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                CargarXmlEnCheckedListBox2(rutaArchivo);
            }
        }

        private void CargarXmlEnCheckedListBox2(string rutaArchivo)
        {
            // Limpia el contenido previo del CheckedListBox
            checkedListBox2.Items.Clear();

            // Cargar el archivo XML en un XmlDocument
            XmlDocument doc = new XmlDocument();
            doc.Load(rutaArchivo);

            // Seleccionar todos los nodos <Auto> en el XML
            XmlNodeList autos = doc.SelectNodes("//Auto");

            // Iterar sobre cada nodo <Auto>
            foreach (XmlNode auto in autos)
            {
                // Crear una lista para almacenar los valores de los subnodos
                List<string> items = new List<string>();

                // Obtener todos los subnodos dentro de este nodo <Auto>
                foreach (XmlNode subNodo in auto.ChildNodes)
                {
                    // Agregar el texto del subnodo a la lista
                    items.Add(subNodo.InnerText.Trim());
                }

                // Combinar los valores de los subnodos en una sola cadena, separados por un espacio
                string textoCombinado = string.Join(" ", items);

                // Agregar la cadena combinada como un ítem en el CheckedListBox
                checkedListBox2.Items.Add(textoCombinado);
            }
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            // Ruta del archivo donde se guardarán las selecciones
            string rutaArchivo = "selecciones.txt";

            // Usar un StreamWriter para anexar al archivo
            using (StreamWriter writer = new StreamWriter(rutaArchivo, append: true))
            {
                // Escribir las selecciones del CheckedListBox1
                writer.WriteLine("(Fecha y Hora: " + DateTime.Now + "):");
                writer.WriteLine("Datos de Cliente:");
                foreach (object item in checkedListBox1.CheckedItems)
                {
                    writer.WriteLine(item.ToString());
                }

                writer.WriteLine(); // Línea en blanco entre listas

                // Escribir las selecciones del CheckedListBox2
                writer.WriteLine("Autos vendidos:");
                foreach (object item in checkedListBox2.CheckedItems)
                {
                    writer.WriteLine(item.ToString());
                }

                writer.WriteLine(); // Línea en blanco al final
            }

            MessageBox.Show("Selecciones guardadas en el archivo: " + rutaArchivo);
        }
    }
}