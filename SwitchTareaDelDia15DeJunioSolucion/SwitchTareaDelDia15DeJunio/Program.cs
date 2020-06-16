using System;

namespace SwitchTareaDelDia15DeJunio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) programa que muestre la tabla del 7");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("2) Programa para determinar un numero primo");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("3) Programa que diga la cantidad de digitos de un numero positivo");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("4) Numero aleatorio entre 50 y 100");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("5) Numeros del 1 al 50 bucle for");

            int ejercicios;

            Console.WriteLine("Ingrese el programa al cual desea acceder: ");
            ejercicios = int.Parse(Console.ReadLine());

            switch (ejercicios)
            {
                case 1:
                    int num = 7;

                    Console.Write("Ingrese su multiplicador: ");

                    for (int i = 2; i <= 12; i++)
                    {
                        Console.WriteLine(i + "x" + num + "=" + i * num + "\n");
                    }

                    Console.ReadKey();
                    break;

                case 2:
                    int a = 0;
                    int nume;

                    Console.WriteLine("Ingrese un numero ");
                    nume = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i < (nume +1 ); i++)
                    {
                        if (nume % i == 0)
                        {
                            a++;
                        }
                    }
                    if (a != 2)
                    {
                        Console.WriteLine("El numero {0} no es un numero primo", nume);
                    }
                    else
                    {
                        Console.WriteLine("El numero {0} si es un numero primo", nume);
                    }
                    break;

                case 3:
                    int numer, dig = 0;
                    Console.WriteLine("Digite un numero ");
                    numer = Convert.ToInt32(Console.ReadLine());

                    while (numer < 0)
                    {
                        Console.WriteLine("Lo siento, tienes que digitar un numero positivo");
                        Console.WriteLine("Intentalo de nuevo");

                        numer = Convert.ToInt32(Console.ReadLine());
                    }

                    if (numer <= 0)
                    {
                        Console.WriteLine("Digite cualquier numero ");
                    }
                    else
                    {
                        do
                        {
                            numer = numer / 10;
                            dig = dig + 1;
                        } while (numer > 0);
                        Console.WriteLine(" su numero tiene {0} digitos", dig);
                        Console.ReadLine();
                    }
                    break;

                case 4:

                    Random aleatorio = new Random();

                    int numero;


                    numero = aleatorio.Next(50, 101);
                    Console.WriteLine("El numero generado es{0}", numero);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Si desea otro numero presione la letra b");

                    string b;
                    b = Console.ReadLine();

                    while (b == "b" || b == "B")
                    {
                        numero = aleatorio.Next(50, 101);

                        Console.WriteLine("El numero generado es {0}", numero);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Si desea terminar presione la letra S");
                        b = Console.ReadLine();
                    }
                    break;

                case 5:
                    Console.WriteLine("Hola Profe");
                    Console.WriteLine("Aqui tiene los numero del 1 al 50 en un ciclo for");

                    for (int i = 0; i <= 50; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                default:
                    Console.WriteLine("Ingrese un numero valido para uno de los problemas");

                    while ((ejercicios < 0) || (ejercicios > 5))
                    {
                        Console.WriteLine("Ingresa Un numero valido");
                        ejercicios = int.Parse(Console.ReadLine());
                    }
                    break;

            }


        }
    }
}
