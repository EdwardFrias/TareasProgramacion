using System;

namespace Elembrion
{
    class Program
    {
        static void Main(string[] args)
        {
            string cedula;
            int pasword;
            string abandonar;
            do
            {
                Console.WriteLine("\nSi quieres abandonar el programa escribe una S, si quieres seguir presione *Enter.*");
                abandonar = Console.ReadLine();
                if (abandonar == "s" || abandonar == "S")
                {
                    Console.WriteLine("\nabandonaste correctamente, ten buen dia . \n");
                    break;
                }
                else while (abandonar == "")
                    {
                        Console.Write("Ingrese su número de cédula: ");
                        cedula = Console.ReadLine();
                        Console.Write("Ingrese su contraseña: ");
                        pasword = int.Parse(Console.ReadLine());
                        while (pasword < 0)
                        {
                            Console.Write("\nNo se permiten números negativos. \n" + "Intentalo de nuevo. \n" + "\n");
                            Console.Write("Ingrese su contraseña: ");
                            pasword = int.Parse(Console.ReadLine());
                        }
                        if (cedula == "40233829825" && pasword == 3602)
                        {
                            Console.WriteLine("\nBienvenido: Edward Frias.\n" + "\nusuario: 402-3382982-5." + "\nClave: 3602." + "\nEstado: Activo. \n" + "Rol: Supervisor. \n" + "Fecha de creación: 07/1/2000. \n");
                            Console.WriteLine("\nSi quieres salir escribe una S");
                            abandonar = Console.ReadLine();
                            if (abandonar == "s" || abandonar == "S")
                            {
                                Console.WriteLine("\nabandonaste correctamente. \n");
                                break;
                            }
                        }
                        else
                        {

                            if (cedula == "21321345212" && pasword == 1234)
                            {
                                Console.WriteLine("\nEsta cuenta está inactiva, vuelve a validar otra cuenta. \n");
                                Console.WriteLine("\nPresiona S para salir");
                                abandonar = Console.ReadLine();
                                if (abandonar == "s" || abandonar == "S")
                                {
                                    Console.WriteLine("\nabandonaste  correctamente. \n");
                                    break;
                                }
                            }
                            else
                            {

                                if (cedula == "23412352455" && pasword == 4521)
                                {
                                    Console.WriteLine("\nBienvenido: Elver Galarga.\n" + "\nusuario: 234-1235245-5." + "\nClave: 4521." + "\nEstado: Activo. \n" + "Rol: Vendedor. \n" + "Fecha de creación: 12/3/2002. \n");
                                    Console.WriteLine("\nSi quieres salir pon una S");
                                    abandonar = Console.ReadLine();
                                    if (abandonar == "s" || abandonar == "S")
                                    {
                                        Console.WriteLine("\nabandonaste  correctamente. \n");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nEl número de cédula y/o contraseña es incorrecta. \n" + "Intentalo de nuevo. (Presiona *ENTER* para continuar o S para salir)");
                                    abandonar = Console.ReadLine();
                                    if (abandonar == "s" || abandonar == "S")
                                    {
                                        Console.WriteLine("\nabandonaste  correctamente. \n");
                                        break;
                                    }
                                }
                            }
                        }
                    }
            } while (abandonar == "s" || abandonar == "S");

        }
    }
}
        