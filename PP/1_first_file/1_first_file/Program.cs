using System;

namespace _1_first_file
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Imie: ");
            //Console.WriteLine("Janusz ");

            //Console.WriteLine("\n#\n##\n###\n####");

            //string name;
            //name = "Kasia";
            //Console.WriteLine("Masz na imie" + name);
            //int wiek = 20;
            //Console.WriteLine("Masz na imie: {0}, wiek: {1}", name, wiek);

            Console.WriteLine("Podaj długosc boku");
            string bok = Console.ReadLine();
            Console.WriteLine("Podaj długosc wysokosc");
            string h = Console.ReadLine();
            double result = (double.Parse(h) * double.Parse(bok))/2;
            Console.WriteLine(result);

            float y =14.54f;


            Console.ReadKey();



        }
    }
}
