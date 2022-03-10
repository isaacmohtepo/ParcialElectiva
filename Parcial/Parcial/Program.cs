using System;
namespace Parcial;
public class Program
{
    public static void Main()
    {

        Alcancia alcancia = new Alcancia();
        int opcion = 0;

        do
        {

            Console.WriteLine("******* Que desea realizar *******");
            Console.WriteLine("1. Agregar Moneda");
            Console.WriteLine("2. Ver cantidad de monedas");
            Console.WriteLine("3. Valor total de monedas");
            Console.WriteLine("4. Cantidad de monedas de una determinada denominacion");
            Console.WriteLine("5. Cantidad total de monedas de una determinada denominacion");
            Console.WriteLine("Ingrese una opcion");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    alcancia.AgregarMoneda();
                    break;
                case 2:
                    Console.Clear();
                    alcancia.CantidadMonedas();
                    break;
                case 3:
                    Console.Clear();
                    alcancia.ValorTotal();

                    break;
                case 4:
                    Console.Clear();
                    alcancia.CantidadMonedasDenominacion();

                    break;
                case 5:
                    Console.Clear();
                    alcancia.CantidadTotalMonedasDenominacion();
                    
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            
            

        } while (opcion != 6);


    }
}