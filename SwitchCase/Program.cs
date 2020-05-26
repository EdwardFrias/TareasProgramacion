using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola profesor!");

            int ejercicio;

            Console.WriteLine("Introduzca el numero del ejercicio que desea abrir; ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1)para  el ejercicio de decir si el 1er numero es multiplo del 2do");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("2)para Ejercicio de division de 2 numeros distintos de 0 ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("3)el mayor de 2 numeros  ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("4)el mayor de 3 numeros reales ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("5)multiplo de 4 o 5");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("6)saber si un numero es multiplo de 10");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("7)numero entero y saber si es par");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("8)saber si los numeros son positivos  o negativos");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("9)producto de 2 numeros distintos de 0");
            Console.WriteLine("----------------------------------------");


            ejercicio = int.Parse(Console.ReadLine());

            switch (ejercicio){

                case 1:
                    /*Crear un programa que pida al usuario dos números enteros y 
                     * diga si el primero
                     es múltiplo del segundo*/

                    Console.WriteLine("Saludos Profesor");

                    int num1;
                    int num2;

                    Console.WriteLine("Ingrese el primer numero");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero");
                    num2 = int.Parse(Console.ReadLine());

                    if ((num1 % num2) == 0) Console.WriteLine("El num1 es multiplo del num2");

                    else Console.WriteLine("El num1 no es multiplo del num2");

                    Console.WriteLine("este es el primer ejercicio");
                    break;

                case 2:

                    /*Crear un programa que pida al usuario dos números enteros. Si el segundo no
              es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el
              contrario, si el segundo número es cero, escribirá "Error: No se puede dividir
              entre cero"*/

                    Console.WriteLine("Hola profesor");

                    int nuM1;
                    int nuM2;
                    int division;

                    Console.WriteLine("Digite el numero entre el que se va a dividir");
                    nuM2 = int.Parse(Console.ReadLine());

                    if (nuM2 != 0)
                    {
                        Console.WriteLine("Como el numero {0} es distinto a 0 entonces", nuM2);
                        Console.WriteLine("Calcularemos la division de 2 numeros");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Digite su segundo numero");
                        nuM1 = int.Parse(Console.ReadLine());

                        division = nuM1 / nuM2;
                        Console.WriteLine("Al dividir {0} entre {1}, obtenemos como resultado {2}", nuM1, nuM2, division);


                    }
                    else
                    {
                        Console.WriteLine("Error no se puede dividir entre 0");
                    }
                    break;

                case 3:

                    /*Crear un programa que pida al usuario dos números enteros y
                * diga cuál es el
                 mayor de ellos*/
                    Console.WriteLine("Hola profe!");

                    int nUm1;
                    int nUm2;

                    Console.WriteLine("Ingrese el primer numero");
                    nUm1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero");
                    nUm2 = int.Parse(Console.ReadLine());

                    if (nUm1 > nUm2) Console.WriteLine("El primer numero es el mayor");

                    else Console.WriteLine("El segundo numero es el mayor ");
                    break;

                case 4:

                    /*crear un programa que pida al usuario tres números reales y muestre cuál es el
                      mayor de los tres.*/

                    Console.WriteLine("Hola profe!");

                    double Num1;
                    double Num2;
                    double Num3;

                    Console.WriteLine("Ingrese el primer numero");
                    Num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero");
                    Num2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el tercer numero");
                    Num3 = double.Parse(Console.ReadLine());

                    if ((Num1 > Num2) && (Num1 > Num3))
                    {
                        Console.WriteLine("El numero {0} es el mayor", Num1);
                    }
                    else if ((Num2 > Num1) && (Num2 > Num3))
                    {
                        Console.WriteLine("El numero {0} es el mayor", Num2);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("El numero {0} es el mayor", Num3);
                    }
                    break;

                case 5:

                    /*Crear un programa que pida al usuario un número entero y diga si es múltiplo
             de 4 o de 5.*/

                    Console.WriteLine("Saludos Profe");

                    int numero;

                    Console.WriteLine("Digite su numero");
                    numero = int.Parse(Console.ReadLine());

                    if ((numero % 4) == 0)
                    {
                        Console.WriteLine("El numero {0} es multiplo de 4", numero);
                    }
                    else if ((numero % 5) == 0)
                    {
                        Console.WriteLine("El numero{0} es multiplo de 5", numero);
                    }
                    else
                    {
                        Console.WriteLine("El numero {0} no es multiplo ni de 4 ni de 5", numero);
                    }

                    break;

                case 6:

                    /*Crear un programa que pida al usuario un número entero. Si es múltiplo de 10,
                      se lo avisará al usuario y pedirá un segundo número, para decir a continuación
                      si este segundo número también es múltiplo de 10.*/

                    Console.WriteLine("Hola Profesor");

                    int numero1;
                    int numero2;

                    Console.Write("Digite el primer numero");
                    numero1 = int.Parse(Console.ReadLine());

                    if (numero1 % 10 == 0)
                    {
                        Console.WriteLine("El numero {0} es multiplo de 10", numero1);
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Digite el segundo numero");
                        Console.WriteLine("-------------------------------------");
                        numero2 = int.Parse(Console.ReadLine());
                        if (numero2 % 10 == 0)
                        {
                            Console.WriteLine("El numero {0} es tambien es multiplo de 10", numero2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El numero {0} no es multiplo de 10", numero1);
                    }
                    break;

                case 7:

                    //Crear un programa que pida al usuario un número entero y diga si es par.
                    Console.WriteLine("Hola Profesor");

                    int Numero;

                    Console.WriteLine("Ingrese su numero");
                    Numero = int.Parse(Console.ReadLine());

                    if ((Numero % 2) == 0) Console.WriteLine("{0} es un numero par", Numero);

                    else Console.WriteLine("{0} es un numero impar", Numero);
                    break;

                case 8:

                    /*Crear un programa que pida al usuario dos números enteros y diga "Uno de los
             números es positivo";, "Los dos números son positivos" o bien", Ninguno de los
             números es positivo";, según corresponda.*/

                    Console.WriteLine("Hola Profesor");

                    int Numero1;
                    int Numero2;

                    Console.WriteLine("Digite su primer numero");
                    Console.WriteLine("------------------");
                    Numero1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite su segundo numero ");
                    Console.WriteLine("------------------");
                    Numero2 = int.Parse(Console.ReadLine());

                    if ((Numero1 > 0) && (Numero2 < 0))
                    {
                        Console.WriteLine("Uno de los 2 numeros es positivo");
                    }
                    else if ((Numero1 > 0) && (Numero2 > 0))
                    {
                        Console.WriteLine("Los 2 numeros son positivos");
                    }
                    else
                    {
                        Console.WriteLine("Ambos Numeros son negativos");
                    }
                    break;

                case 9:


                    /*Crear un programa que multiplique dos números enteros de la siguiente forma:
                    pedirá al usuario un primer número entero. Si el número que se que teclee es 0,
                    escribirá en pantalla "El producto de 0 por cualquier número es 0". Si se ha
                    tecleado un número distinto de cero, se pedirá al usuario un segundo número y
                    se mostrará el producto de ambos.*/

                    Console.WriteLine("Saludos profesor");

                    int number1;
                    int number2;
                    int producto;

                    Console.WriteLine("Digite su primer numero");
                    number1 = int.Parse(Console.ReadLine());

                    if (number1 != 0)
                    {
                        Console.WriteLine("Como el numero {0} es distinto a 0 entonces", number1);
                        Console.WriteLine("Calcularemos el producto de 2 numeros");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Digite su segundo numero");
                        number2 = int.Parse(Console.ReadLine());

                        producto = number1 * number2;
                        Console.WriteLine("Al multiplicar {0} por {1}, obtenemos como resultado {2}", number1, number2, producto);


                    }
                    else
                    {
                        Console.WriteLine("El producto de multiplicar cualquier numero por 0 es 0");
                    }
                    break;
            }
            
        }
    }
}
