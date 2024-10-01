using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceAFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceAFibonacci(int n)
    {
        int a = 0, b = 1, c = 0;
        if (n == 0 || n == 1)
            return true;

        while (c < n)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c == n;
    }
}
