using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Alcancia
    {
        public int moneda;
        public static List<Alcancia> monedaList = new List<Alcancia>();

        //metodo que solo pueda recibir monedas de 50, 100, 200, 500, 1000 en una lista
        public void AgregarMoneda()
        {
            Console.WriteLine("Ingrese la cantidad de moneda que desea agregar");
            int cantidad = int.Parse(Console.ReadLine());
            if (cantidad == 50 || cantidad == 100 || cantidad == 200 || cantidad == 500 || cantidad == 1000)
            {
                moneda = cantidad;
                monedaList.Add(this);
            }
            else
            {
                Console.WriteLine("No se puede agregar esa cantidad de moneda");
            }
        }

        //cantidad de monedas 
        public void CantidadMonedas()
        {
            Console.WriteLine("La cantidad de monedas es: " + monedaList.Count);
        }

        //valor total de las monedas
        public void ValorTotal()
        {
            int total = 0;
            foreach (Alcancia moneda in monedaList)
            {
                total += moneda.moneda;
            }
            Console.WriteLine("El valor total de las monedas es: " + total);
        }

        //cantidad de monedas de una determinada denominacion
        public void CantidadMonedasDenominacion()
        {
            Console.WriteLine("Ingrese la denominacion de la moneda que desea ver");
            int denominacion = int.Parse(Console.ReadLine());
            int cantidad = 0;
            foreach (Alcancia moneda in monedaList)
            {
                if (moneda.moneda == denominacion)
                {
                    cantidad++;
                }
            }
            Console.WriteLine("La cantidad de monedas de la denominacion " + denominacion + " es: " + cantidad);
        }


        //cantidad total de monedas de una determinada denominacion
        public void CantidadTotalMonedasDenominacion()
        {
            Console.WriteLine("Ingrese la denominacion de la moneda que desea ver");
            int denominacion = int.Parse(Console.ReadLine());
            int cantidad = 0;
            foreach (Alcancia moneda in monedaList)
            {
                if (moneda.moneda == denominacion)
                {
                    cantidad += moneda.moneda;
                }
            }
            Console.WriteLine("La cantidad total de monedas de la denominacion " + denominacion + " es: " + cantidad);
        }

       

    }
}
