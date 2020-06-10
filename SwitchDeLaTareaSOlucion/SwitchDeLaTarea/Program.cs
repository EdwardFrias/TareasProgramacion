using System;
using System.Runtime.CompilerServices;

namespace SwitchDeLaTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YAce aqui la tarea!");

            int ejercicios;

            Console.WriteLine("1-) Ejercicio valor absoluto");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("2-) ejercicio de  el menor de 2 numeros");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("3-) Tipo de caracter");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("4-) Tipo de caracter, con vocales y con constantes");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("5-) NUmeros pares comprendidos entre 23 y 7");

            ejercicios = int.Parse(Console.ReadLine());

            switch (ejercicios)
            {
                case 1:
                    int num;

                    Console.WriteLine("Ingrese un numero cual sea");
                    num = int.Parse(Console.ReadLine());

                    if (num > 0)
                    {
                        Console.WriteLine("El numero {0} es un numero positivo, por lo tanto su valor absoluto es {0}", num);
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine("El numero ingresado es {0} : ", num);
                        num = num * (-1);
                        Console.WriteLine("por lo tanto el  valor absoluto es {0} ", num);
                    }
                    break;

                case 2:


                    Console.WriteLine("Hola Profesor");

                    int nume1;
                    int nume2;

                    Console.WriteLine("Ingrese el primer numero");
                    nume1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero");
                    nume2 = int.Parse(Console.ReadLine());

                    if ((nume1 > nume2))
                    {
                        Console.WriteLine("El numero mayor es {0}", nume1);
                    }
                    else
                    {
                        Console.WriteLine("El numero mayor es {0}", nume2);
                    }
                    break;

                case 3:

                    char caracter;

                    Console.WriteLine("Introduce un caracter");
                    caracter = Convert.ToChar(Console.ReadLine());

                    switch (caracter)
                    {
                        case ' ':
                            Console.WriteLine("Ha introducido un espacio");
                            break;
                        case '1': goto case '0';
                        case '2': goto case '0';
                        case '3': goto case '0';
                        case '4': goto case '0';
                        case '5': goto case '0';
                        case '6': goto case '0';
                        case '7': goto case '0';
                        case '8': goto case '0';
                        case '9': goto case '0';
                        case '0':
                            Console.WriteLine("El caracter {0} es un numero", caracter);
                            break;


                        case ',': goto case '.';
                        case ';': goto case '.';
                        case ':': goto case '.';
                        case '?': goto case '.';
                        case '¿': goto case '.';
                        case '!': goto case '.';
                        case '(': goto case '.';
                        case ')': goto case '.';
                        case '[': goto case '.';
                        case ']': goto case '.';
                        case '-': goto case '.';
                        case '"': goto case '.';
                        case '{': goto case '.';
                        case '}': goto case '.';
                        case '.':
                            Console.WriteLine("el caracter {0} es un signo de puntuacion", caracter);
                            break;

                        default:
                            Console.WriteLine("El caracter {0} es una letra ", caracter);
                            break;
                    }
                    break;

                case 4:

                    char caractere;

                    Console.WriteLine("Introduce un caracter");
                    caractere = Convert.ToChar(Console.ReadLine());

                    switch (caractere)
                    {
                        case ' ':
                            Console.WriteLine("Ha introducido un espacio");
                            break;
                        case 'e': goto case 'a';
                        case 'i': goto case 'a';
                        case 'o': goto case 'a';
                        case 'u': goto case 'a';
                        case 'a':
                            Console.WriteLine("El caracter {0} es una vocal", caractere);
                            break;

                        case '1': goto case '0';
                        case '2': goto case '0';
                        case '3': goto case '0';
                        case '4': goto case '0';
                        case '5': goto case '0';
                        case '6': goto case '0';
                        case '7': goto case '0';
                        case '8': goto case '0';
                        case '9': goto case '0';
                        case '0':
                            Console.WriteLine("El caracter {0} es una cifra numerica ", caractere);
                            break;

                        default:
                            Console.WriteLine("El caracter {0} es una constante ", caractere);
                            break;
                    }
                    break;

                case 5:


                    int numerote = 23;

                    numerote = numerote - 1;


                    while (numerote > 7)
                    {
                        Console.WriteLine(numerote);
                        numerote = numerote - 2;

                    }

                    break;

                default:
                    Console.WriteLine("Ingrese un numero del 1 al 5 solamente");
                    break;
            }
        }
    }
}
