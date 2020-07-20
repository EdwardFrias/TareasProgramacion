using System;

namespace PiedraPapelOTijera
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("¡Bienvenido al juego de Piedras, Papel o Tijeras! \n Presiona cualquier tecla para comenzar...");
                Console.ReadKey();

            }


            int pc, accion;
            String nombre;
            Random pcP = new Random();
            pc = pcP.Next(1, 3);


            Console.WriteLine("¿Cual es tu nombre?");
            nombre = Console.ReadLine();

            Console.WriteLine($"Hola {nombre} a continuacion jugaras vs Computadora");
            Console.WriteLine("Elije la accion a realizar \n 1. Piedra \n 2. Papel \n 3. Tijera");
            accion = Convert.ToInt32(Console.ReadLine());


            if (pc == accion)

            {
                Console.WriteLine("Empate");
            }

            else if ((pc == 1) && (accion == 2))
            {
                Console.WriteLine("Has ganado elejiste papel y la computadora piedra \n       (Papel derrota a Piedra)");
            }

            else if ((pc == 2) && (accion == 3))
            {
                Console.WriteLine("Has ganado elejiste tijera  y la computadora papel \n       (Tijera derrota a Papel)");
            }

            else if ((pc == 3) && (accion == 1))

            {
                Console.WriteLine("Has ganado elejiste Piedra y la computadora Tijera \n      (Piedra derrota a tijeras)");
            }

            else if ((pc == 1) && (accion == 3))

            {
                Console.WriteLine("Has perdido elejiste Piedra y la computadora tijera \n     (Piedra derrota a Tijeras)");
            }

            else if ((pc == 3) && (accion == 2))
            {
                Console.WriteLine("Has perdido elejiste Tijera y la computadora Papel \n      (Tijera derrota a Papel)");
            }

            else if ((pc == 2) && (accion == 1))
            {
                Console.WriteLine("Has perdido elejiste Papel y la computadora Piedra \n      (Papel derrota a Piedra)");
            }

            Console.ReadKey();
        }
    }
}
