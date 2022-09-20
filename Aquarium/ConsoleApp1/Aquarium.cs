using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Aquarium
    {
        public void Aquarium_Creation()
        {
            Console.WriteLine("Wie groß soll das Aquarium sein?");
            Console.WriteLine("Höhe:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Länge:");
            int y = Convert.ToInt32(Console.ReadLine());

            string[,] aquarium = new string[x, y];


            Console.Clear();

            for (int j = 0; j < x; j++)
            {

                for (int i = 0; i < y; i++)
                {
                    if (i == 0 || i == y - 1)
                    {
                        aquarium[j, i] = "|";
                    }
                    else
                    {
                        aquarium[j, i] = " ";
                    }
                    if (j == x - 1)
                    {
                        aquarium[j, i] = "-";
                    }

                }
            }
            for (int j = 0; j < x; j++)
            {

                for (int i = 0; i < y; i++)
                {
                    Console.Write(aquarium[j, i]);
                }
                Console.Write("\n");
            }
        }
    }
}
