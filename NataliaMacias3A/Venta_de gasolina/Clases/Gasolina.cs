using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_gasolina.Clases
{
    class Gasolina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int c_galones;

        public int C_Galones
        {
            get { return c_galones; }
            set { c_galones = value; }
        }


        public double Precio_Venta
        {
            get
            {

                if (this.Tipo == "Extra")
                {
                    return 1.50;
                }
                else
                {
                    return 2.00;
                }
            }
        }


        public double Subtotal
        {
            get { return Precio_Venta * C_Galones; }

        }


        public double Iva
        {
            get { return (Subtotal * 12) / 100; }

        }


        public double Total
        {
            get { return Iva + Subtotal; }

        }

    }
}
