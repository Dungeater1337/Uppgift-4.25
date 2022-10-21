using System; 

namespace uppgift_4_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("välj ett av följande alternativ");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera ett tal med ett annat");
            Console.WriteLine("3. Avsluta programmet");
            int svar = int.Parse(Console.ReadLine());

            switch (svar)
            {
                case 1:
                    Console.WriteLine("Välj ett tal");
                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("välj ett till tal");
                    int tal2 = int.Parse(Console.ReadLine());
                    int svar2 = tal1 - tal2;
                    Console.WriteLine("Du får " + svar2);
                    
                    break;

                case 2:
                    Console.WriteLine("Välj ett tal");
                    int tal3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("välj ett till tal");
                    int tal4 = int.Parse(Console.ReadLine());
                    int svar3 = tal3 / tal4;
                    Console.WriteLine("Du får " + svar3);

                    break;
            }

            if(svar == 3)
            {
                Console.WriteLine("Du har valt att avsluta Programmet");
            }
        }
    }
}