#region Ex01
using System;

class Pares
{
    static void Main()
    {
        for (int i = 1; i < 21; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}
#endregion

#region Ex02
using System;

class Soma
{
    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int N = int.Parse(Console.ReadLine());
        int soma = 0;

        for (int i = 1; i <= N; i++)

            soma += i;

        Console.WriteLine($"A soma é: {soma}");

    }
}
#endregion

#region Ex03
using System;

class Fatorial
{
    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int N = int.Parse(Console.ReadLine());
        int soma = 1;
        int i;

        for (i = N; i >= 1; i--)

        soma *= i;

        Console.WriteLine($"{soma}");
    }
}
#endregion

#region Ex04
using System;

class Fatorial
{
    static int CalcularFatorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * CalcularFatorial(n - 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(CalcularFatorial(n));
    }
}
#endregion
