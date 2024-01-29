

//class Program
//{



//    static void Dec2Bin(int n)
//    {
//        if (n > 0)
//        {
//            int num = n % 2;

//            Dec2Bin(n / 2);

//            Console.Write(num);
//        }
//    }
//    static void Main(string[] args)
//    {
//        Console.Write("Digite um número decimal: ");
//        int num = int.Parse(Console.ReadLine());
//        Console.Write("Representação binária: ");
//        Dec2Bin(num);
//        Console.WriteLine();
//    }

//}

//    static void Dec2bin(int n)
//    {
//        if(n > 0)
//        {
//             num = n % 2;
//            Dec2bin(n / 2);
//            Console.Write(num);

//        }

//    }

class Program
{

    static int Fib(int x)
    {

        if (x <= 1) return 1;
        return (Fib(x - 1) + Fib(x - 2));

    }

    static void Main(string[] args)
    {

        int num;

        Console.WriteLine("Digite um número:");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("Com recursividade:");

        Console.WriteLine(Fib(num - 1));
        Console.ReadKey();

    }

}