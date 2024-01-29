class Program
{
    static void Dec2Bin(int n)
    {
        if (n > 0)
        {
            Dec2Bin(n / 2);
            Console.Write(n % 2);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Digite um número decimal: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Representação binária: ");
        Dec2Bin(num);

        
    }
}