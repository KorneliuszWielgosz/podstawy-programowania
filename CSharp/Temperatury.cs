using System;

class Temperatury
{
    static void Main()
    {
        Console.WriteLine("KONWERTER TEMPERATUR");
        Console.Write("Wybierz skale (C/F): ");
        string skala = Console.ReadLine().ToUpper();

        Console.Write("Podaj temperature: ");
        double temperatura = Convert.ToDouble(Console.ReadLine());

        if (skala == "C")
        {
            Console.WriteLine("Temperatura w Fahrenheitach: " +
                (temperatura * 1.8 + 32));
        }
        else if (skala == "F")
        {
            Console.WriteLine("Temperatura w Celsjuszach: " +
                ((temperatura - 32) / 1.8));
        }
        else
        {
            Console.WriteLine("Nieprawidlowy wybor skali.");
        }
    }
}
