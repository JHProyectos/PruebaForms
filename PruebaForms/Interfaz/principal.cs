using PruebaForms.Interfaz;

namespace PruebaForms
{
    public partial class principal : Form
    {

        public principal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha actual: " + DateTime.Today.ToString("dd/MM/yyyy");
        }
        private void tsmClientes_Click(object sender, EventArgs e)
        {
            datosClientes datosClientes = new datosClientes();
            datosClientes.Show();
        }
        private void tsmProvedoores_Click(object sender, EventArgs e)
        {
            datosProveedores datosProveedores = new datosProveedores();
            datosProveedores.Show();
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datosProductos datosProductos = new datosProductos();
            datosProductos.Show();
        }
        private void tsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaVentas VentanaVentas = new VentanaVentas();
            VentanaVentas.Show();

        }
    }
}
