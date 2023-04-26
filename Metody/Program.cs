using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //METODY

            double wynik = Math.Pow(2, 10);
            Console.WriteLine(wynik);

            Console.WriteLine( Dodawanie(10, 20) );
            Console.WriteLine( Mnożenie(10, 20, 10) );

            //1.Napisz kod, który wydrukuje w konsoli prostokąt z * o podanej wysokości i szerokości.

            //gotowy

            //2.Przenieś kod do metody i wywołaj go.

            Console.WriteLine( Rysuj(5, 6, "A") );
            Console.WriteLine();
            Console.WriteLine( Rysuj(7, 3, "B") );

            //Zalety metody:
            // 1.Zmniejsza ilość kodu, możemy wykorzystywać 1 fragment wiele razy
            // 2.Zwiększa czytelność kodu


            Console.ReadLine();

        }
        // metoda która dodaje do siebie 2 liczby i zwraca wynik

        //nagłówek metody:
        //public static - zawsze piszemy (stały element metody)
        //int - typ jaki zwraca metoda może być dowolny (int, double, string... itd.)
        //Dodawanie - nazwa metody
        //(int a, int b) - składniki metody, parametry, używamy ich w ciele do wykonania akcji
        public static int Dodawanie(int a, int b)
        {
            int wynik = a + b;
            return wynik;
        }

        //napisz metodę typu double, która będzie mnożyć 3 liczby
        public static double Mnożenie (double a, double b, double c)
        {
            return a * b * c;
        }

        //metoda do rysowania
        public static string Rysuj(int szerokość, int wysokość, string znak)
        {
            string prostokąt = "";

            for (int i = 0; i < wysokość; i++)
            {
                for (int j = 0; j < szerokość; j++)
                {
                    prostokąt = prostokąt + znak;
                }
                // \r\n  to znak nowej linii dodajemy go aby prostokąt wyświetlał się poprawnie
                prostokąt = prostokąt + "\r\n";
            }

            return prostokąt;
        }
    }
}
