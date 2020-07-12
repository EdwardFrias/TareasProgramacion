using System;

namespace ParcialDeVotacione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de votaciones de la junta \n" + "\nCandidatos a la presidencia son: \n" + "\n1.Gonzalo Castillo (Presidente). Partido: Partido de la Liberacion Dominicano (PLD). Año: 1233. \n" + "2.Luis Abinader (Presidente). Partido: Partido Revolucionaro Moderno (PRM). Año: 2016. \n" + "3.Leonel Fernandez (Presidente). Fucking Para (FP). Año: 220. \n" + "4.Miguel Moreno (Presidente). Alianza Pais (ALPAÍS). Año: 2000. \n");
            Random rng = new Random();
            int[] nc = { 0, 0, 0, 0 };
            double total, A1, A2, A3, A4;

            for (int i = 1; i < 1001; i++)
            {
                int vr = rng.Next(1, 5);
                if (vr == 1)
                {
                    nc[0] += 1;
                }
                if (vr == 2)
                {
                    nc[1] += 1;
                }
                if (vr == 3)
                {
                    nc[2] += 1;
                }
                if (vr == 4)
                {
                    nc[3] += 1;
                }
            }
            Console.WriteLine("Aqui están los votos: \n" + "\nGonzalo cuenta con : " + nc[0] + " votos." + "\n" + "Abinader cuenta con: " + nc[1] + " votos." + "\n" + "Leonel tiene: " + nc[2] + " votos." + "\n" + "Guillermo moreno tiene: " + nc[3] + " votos." + "\n");

            total = nc[0] + nc[1] + nc[2] + nc[3];
            A1 = (nc[0] / total) * 100;
            A2 = (nc[1] / total) * 100;
            A3 = (nc[2] / total) * 100;
            A4 = (nc[3] / total) * 100;

            Console.WriteLine("\nEl porcentaje sería: \n" + "\nGonzalo tiene: " + A1.ToString("N2") + "%" + "\n" + "Abinader tiene: " + A2.ToString("N2") + "%" + "\n" + "Leonel Fernandez tiene: " + A3.ToString("N2") + "%" + "\n" + "Guillermo tiene: " + A4.ToString("N2") + "%" + "\n");

            if (nc[0] > nc[1] && nc[0] > nc[2] && nc[0] > nc[3])
            {
                Console.WriteLine("El ganador es: Gonzalo Castillo.");
            }
            if (nc[1] > nc[0] && nc[1] > nc[2] && nc[1] > nc[3])
            {
                Console.WriteLine("El ganador es: Luis Abinader.");
            }
            if (nc[2] > nc[1] && nc[2] > nc[0] && nc[2] > nc[3])
            {
                Console.WriteLine("El ganador es: Leonel Fernandez.");
            }
            if (nc[3] > nc[2] && nc[3] > nc[0] && nc[3] > nc[1])
            {
                Console.WriteLine("El ganador es: Guillermo Moreno.");
            }
            if (nc[0] == nc[1])
            {
                Console.WriteLine("Empate entre Gonzalo y Abinader");
            }
            if (nc[0] == nc[2])
            {
                Console.WriteLine("Empate entre Gonzalo y Leonel");
            }
            if (nc[0] == nc[3])
            {
                Console.WriteLine("Empate entre Gonzalo y GUillermo moreno");
            }
            if (nc[2] == nc[1])
            {
                Console.WriteLine("Empate entre Leonel y Luis Abinader");
            }
            if (nc[2] == nc[3])
            {
                Console.WriteLine("Empate entre Leonel Y Guillermo Moreno");
            }
            if (nc[1] == nc[3])
            {
                Console.WriteLine("Empate  Abinader Y Guillermo moreno");
            }
            Console.WriteLine("\n total de votos ordenados: " + "\n");
            for (int i = 0; i < nc.Length; i++)
            {
                for (int j = i + 1; j < nc.Length; j++)
                {
                    int aux;
                    if (nc[i] > nc[j])
                    {
                        aux = nc[i];
                        nc[i] = nc[j];
                        nc[j] = aux;
                    }
                }

            }
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(nc[i]);
            }
            Console.ReadKey();
        }
    }
}
