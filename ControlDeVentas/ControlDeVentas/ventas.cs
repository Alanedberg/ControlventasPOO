using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeVentas
{
    internal class Ventas
    {
        //Campos
        private int _cantidad;
        private String _Producto;


        //constructor
        public String Producto
		{
			get { return _Producto; }
			set { _Producto = value; }
		}

        public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}


		//metodo para reflejar el precio del producto

		public double ReflejarPrecio()
		{
			switch (Producto)
			{
				case "Bocina": return 70;
				case "Teclado": return 150;
				case "PC Gamer": return 90;
				case "Audifonos": return 325;
			}
			return 0;
		}

	}
}
