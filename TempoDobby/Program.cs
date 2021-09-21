using System;

namespace TempoDobby
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split();
            string[] line2 = Console.ReadLine().Split();

            int finalExpediente = int.Parse(line1[0]);

            int presente1 = int.Parse(line2[0]);
            int presente2 = int.Parse(line2[1]);

            if ((presente1 + presente2) <= finalExpediente)
            {
                Console.WriteLine("Farei hoje!");
            }
            else
            {
                Console.WriteLine("Deixa para amanha!");
            }
        }
    }
}
