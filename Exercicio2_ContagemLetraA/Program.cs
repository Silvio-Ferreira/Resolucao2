using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe uma string: ");
        string texto = Console.ReadLine().ToLower();

        int contador = ContarLetrasA(texto);

        if (contador > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {contador} vezes na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não aparece na string.");
        }
    }

    static int ContarLetrasA(string texto)
    {
        int count = 0;
        foreach (char c in texto)
        {
            if (c == 'a')
            {
                count++;
            }
        }
        return count;
    }
}
