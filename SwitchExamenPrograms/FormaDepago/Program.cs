using System;

namespace FormaDepago
{
    class Program
    {
        static void Main(string[] args)
        {

            int ejercicio;

            Console.WriteLine("Introduzca el numero del ejercicio que desea saber ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Pulse 1 para programa acerca del metodo de pago ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Pulse 2 para programa acerca del dia de la semana");

            ejercicio = int.Parse(Console.ReadLine());

            switch (ejercicio)
            {

                case 1:

                    /*Pedir al usuario el precio de un producto y la forma de pagar (efectivo o tarjeta) 
                     * si la forma de pago es mediante tarjeta, pedir el numero de tarjeta (12 digitos).
                     * Ojo, validar que el valor ingresado en el sea positivo. */

                    double valor;
                    string forma;

                    Console.WriteLine("Buenas tardes , indiqueme el precio de su producto!");
                    valor = double.Parse(Console.ReadLine());

                    Console.WriteLine("Que metodo de pago utilizara:Tarjeta o efectivo");
                    forma = (Console.ReadLine());

                    if (forma.Equals("tarjeta"))
                    {
                        Console.WriteLine("Introduzca el numero de su tarjeta de 12 digitos por favor");
                        int tarjeta = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El pago del producto de valor {0}RD$ ha sido extraido de la cuenta {1} y ha sido pago con exito", valor, tarjeta);
                    }
                    else if (forma.Equals("efectivo"))
                    {
                        Console.WriteLine("El pago del producto de valor {0}RD$ ha sido efectuado", valor);
                    }

                    else
                    {
                        Console.WriteLine("Seleccione un metodo de pago correcto por favor");
                    }
                    break;

                case 2:
                    Console.WriteLine("Escriba un dia de la semana");
                    string dia = Console.ReadLine();

                    switch (dia.ToLower())
                    {
                        case "lunes":
                        case "martes":
                        case "miercoles":
                        case "jueves":
                        case "viernes":
                            Console.WriteLine("hoy es {0} y tienes que ir a trabajar", dia);
                            break;

                        case "sabado":
                        case "domingo":
                            Console.WriteLine("Hoy es {0} y es fin de semana, puedes salir a beber", dia);
                            break;

                        default:
                            Console.WriteLine("El dato ingresado no es valido, escriba un dia de la semana");
                            break;


                    }
                    break;

                default:
                    Console.WriteLine("Seleccione un numero correcto");
                    break;
            }
        }   
    }   
}
