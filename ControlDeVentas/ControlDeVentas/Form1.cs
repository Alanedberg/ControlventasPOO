using MaterialSkin.Controls;
using System.Collections;

namespace ControlDeVentas
{
    public partial class FrmPanelVentas : MaterialForm
    {
        public FrmPanelVentas()
        {
            InitializeComponent();
        }

        //Instancio mi clase ventas
        Ventas objV = new Ventas();



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
            cmbProducto.Text = "";
            txtCantidad.Clear();
            lblPrecio.Text = "0.00";
            cmbProducto.Text = "Seleccione el producto...";
            txtDatosClientes.Focus();
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
            string[] productos = { "Bocina", "Teclado", "PC Gamer", "Audifonos" };

            //ForEach e itero en mi lista
            foreach (var p in productos)
            {
                //Relleno mi comboBox
                cmbProducto.Items.Add(p);
            }

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseas Salir del sistema?", "Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //Condicional el diablo del mensaje
            if (resultado == DialogResult.OK)
            {
                LimpiarCampos();
            }
       
        }

        private void cmbProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            objV.Producto = cmbProducto.Text;

            lblPrecio.Text = objV.ReflejarPrecio().ToString("C");
        }
    }
}
