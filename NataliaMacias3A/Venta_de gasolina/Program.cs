using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_de_gasolina.Clases;

namespace Venta_de_gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Gasolina gasolina = new Gasolina();


            Console.WriteLine("Ingrese los apellidos del cliente: ");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese los nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nùmero de cedula de" +
                " identidad del cliente : ");
            cliente.Nc_Identificacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la dirección cliente: ");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo de gasolina que requiere : ");
            gasolina.Tipo = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de gasolina: ");
            gasolina.C_Galones = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Subtotal:" + gasolina.Subtotal);
            Console.WriteLine("Iva:" + gasolina.Iva);
            Console.WriteLine("Total:" + gasolina.Total);
            Console.ReadLine();
        }
    }
}
