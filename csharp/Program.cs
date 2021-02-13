using System;

namespace Exponentialfunktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _nochmal;
            do
            {
                Console.Write("Startwert auf der Y Achse(c): ");        //Z12-Z19 sind die inputs für die formel f(x) = c*a^x
                int c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Wachstumsfaktor(a): ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Start-X(im koordinatensystem): ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ende-X(im Koordinatensystem, Zeit): ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                x1 = x1 + 1;
                Console.Clear();                                //cleart die konsole, dass es einfacher zu lesen ist
                double ergebnis = c * a;             //das ergebnis, so wie der Wachstumsfaktor sind doubles weil es dezimalzahlen sind, und nicht "decimal", da man keine decimals mit Math.Pow() benutzen kann.
                for (int y = 0; x <  x1; x++)
                {
                    Console.Write("S(" + x + " | ");            //das ist einfach ne vertikale wertetabelle
                    Console.Write(Math.Pow(ergebnis, x));       //Math.Pow() ist x^y
                    Console.WriteLine(")");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Noch einmal? (ja/nein)");        //fragt, ob nochmal 
                string nochmal = Console.ReadLine();
                if (nochmal == "ja")
                {
                    _nochmal = true;
                    Console.Clear();        //cleart die konsole, dass es beim nächsten mal besser aus sieht
                }
                else
                {
                    _nochmal = false;
                }
            } while (_nochmal);
            Console.ReadKey();      //das macht, dass ich 1 knopf drücken muss, dass es sich schließt.
        }
    }
}