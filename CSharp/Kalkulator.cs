using System;

class Kalkulator
{
    static void Main()
    {
        Console.Write("Podaj pierwsza liczbe: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj druga liczbe: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz dzialanie (+, -, *, /): ");
        string dzialanie = Console.ReadLine();

        if (dzialanie == "+")
            Console.WriteLine("Wynik: " + (a + b));
        else if (dzialanie == "-")
            Console.WriteLine("Wynik: " + (a - b));
        else if (dzialanie == "*")
            Console.WriteLine("Wynik: " + (a * b));
        else if (dzialanie == "/")
        {
            if (b == 0)
                Console.WriteLine("Nie mozna dzielic przez zero.");
            else
                Console.WriteLine("Wynik: " + (a / b));
        }
        else
            Console.WriteLine("Nieprawidlowe dzialanie.");
    }
}
