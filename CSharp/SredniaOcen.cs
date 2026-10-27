using System;

class SredniaOcen
{
    static void Main()
    {
        Console.Write("Ile ocen chcesz podac? ");
        int liczbaOcen = Convert.ToInt32(Console.ReadLine());

        if (liczbaOcen <= 0)
        {
            Console.WriteLine("Liczba ocen musi byc wieksza od zera.");
            return;
        }

        double suma = 0;

        for (int i = 1; i <= liczbaOcen; i++)
        {
            Console.Write("Podaj ocene " + i + " (1-6): ");
            double ocena = Convert.ToDouble(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / liczbaOcen;

        Console.WriteLine("Srednia ocen: " + Math.Round(srednia, 2));

        if (srednia >= 3.0)
            Console.WriteLine("Zaliczenie: TAK");
        else
            Console.WriteLine("Zaliczenie: NIE");
    }
}
