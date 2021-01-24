using System;

namespace oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0,100);
            int i = 1;
            while (true)
            {
                Console.WriteLine("Number Of Estimates:" + i + "\nEnter a number: ");
                i++;
                string cevap = Console.ReadLine();
                int cevap_sayi = Convert.ToInt32(cevap);
                if (cevap_sayi == sayi)
                {
                    Console.WriteLine("Bravo!!! this is true number");
                    break;
                }
                else if (Math.Abs(cevap_sayi - sayi) < 5)
                    Console.WriteLine("Really u r so close to the answer");
                else if (Math.Abs(cevap_sayi - sayi) < 10)
                    Console.WriteLine("You r close to the answer");
                else if (Math.Abs(cevap_sayi - sayi) < 15)
                    Console.WriteLine("You're almost close to the answer. ");
                else if (Math.Abs(cevap_sayi - sayi) < 20)
                    Console.WriteLine("You're not close to the answer. ");
                else
                    Console.WriteLine("You're definitely not close to the answer.");

            }
        }
        
    }
}
