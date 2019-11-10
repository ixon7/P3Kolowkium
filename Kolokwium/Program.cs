using System;
using System.Collections;

//Grupa A
// Funkcje, która zwróci wynik w/g wzoru: y=2*x^3 - 8*x^2 - 3*x +10
// W podanej tablicy znajdują się zyski ze sprzedaży danego dnia. Utwórz tablicę która będzie zawierać sumę zysków danego dnia od początku miesiąca.
// Stwórz funkcję, która zwróci błęboką kopię dwuwymiarowej tablicy poszarpanej jako dwuwymiarową tablicę protokotną. 
// * wszystkie funkcje umieść w oddzielnej klasie, Funkcja z zdadania pierwszego powinna być statyczna, reszta klasycznie.
// Wywołaj metody tej klasy w main().

namespace Kolokwium
{
    class Program
    {
        
        static void Z1(float x)
        {
            float y;
            y = 2 * (x * x * x) - 8 * (x * x) - 3 * x + 10;
            Console.WriteLine("Zadanie 1 - Wynik: "+ y);
        }
        

        static void Z2(ref int [] tablica,int day)
        {
            Console.WriteLine("Zadanie 2:");
            for (int i = 1; i < day+1; i++)
            {
                tablica[0] += tablica[i];
            }
            Console.WriteLine("Suma z 3 dni to: ");
            Console.WriteLine(tablica[0]);
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Zadania z kolokwium:");
            float x = 10;
            int[] tab1 = { 0, 200, 300, 400, 500, 600, 700, 800, 900, 100 };
            int y = 3; // dzień do którego liczymy sumę z zadania 2
            Z1(x);
            Z2(ref tab1,y);
        }
    }
}
