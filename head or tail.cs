class Moeda
{
    static void Main(string[] args)
    {
        Random sorteio = new Random();
        int resultado = sorteio.Next(0, 2);

        if (resultado == 0)
        {
            Console.WriteLine("Cara");
        }
        else
        {
            Console.WriteLine("Coroa");
        }
    }
}