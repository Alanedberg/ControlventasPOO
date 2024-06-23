using System.Collections;

namespace ControlDeVentas
{
    public partial class FrmPanelVentas : Form
    {
        public FrmPanelVentas()
        {
            InitializeComponent();
        }





        //Funcion para mostrar la fecha y ahora
        private void MostrarFechayHora()
        {
            //Asigno al label la funcion de la fecha y hora segun corresponda
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        //Funcion para limpiar los campos al cancelar
        private void LimpiarCampos()
        {
            txtDatosClientes.Clear();
            cmbProducto.Text = "Seleccione un producto..";
            txtCantidad.Clear();
            lblPrecio.Text = "0.00";
            txtDatosClientes.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Campos limpios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmPanelVentas_Load(object sender, EventArgs e)
        {
            MostrarFechayHora();
            CargarProductos();
        }
        
        //funcion para cargar mis productos
        private void CargarProductos()
        {
            //Lista de productos
            string[] productos = [ "Bocina", "Teclado", "PC Gamer", "Audifonos" ];

            //ForEach e itero en mi lista
            foreach(var p in productos)
            {
                //Relleno mi comboBox
                cmbProducto.Items.Add(p);
            }
            
        }
    }
}
