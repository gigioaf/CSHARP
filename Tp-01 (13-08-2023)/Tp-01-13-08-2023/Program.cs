class Program
{ 

//1



    
    //    static void Main(string[] args)
    //{
    //    int N;
    //    do
    //    {

    //        Console.WriteLine("Digite um Numero Inteiro: ");
    //        N = int.Parse(Console.ReadLine());

    //    } while (N < 1);

    //    Console.Clear();

    //    Calculo(N);




    //}
    //static void Calculo(int N)
    //{
    //    int F = 1;
    //    for (int i = N; i >= 1; i--)
    //    {

    //        F = F * i; 

    //    }

    //    Console.WriteLine(F);
    //}


    //2


    //{

    //    static void Main(string[] args)

    //    {

    //        int anos, meses, dias;

    //        Console.Write("Digite a idade em anos: ");
    //        anos = int.Parse(Console.ReadLine());

    //        Console.Write("Digite a idade em meses: ");
    //        meses = int.Parse(Console.ReadLine());

    //        Console.Write("Digite a idade em dias: ");
    //        dias = int.Parse(Console.ReadLine());

    //        Calculo(anos, meses, dias);

    //    }

    //    static void Calculo(int anos, int meses, int dias)
    //    {

    //        int idadeEmDias = (anos * 365) + (meses * 30) + dias;

    //        Console.WriteLine($"A idade em dias é: {idadeEmDias} dias");
    //    }

    //}

    //3


    //{

    //    public static void Main(string[] args)
    //    {
    //        int N, A, B;


    //        Console.WriteLine("Escolha uma operação");

    //        Console.WriteLine("Digite 1 - Adição");

    //        Console.WriteLine("Digite 2 - Subtração");

    //        Console.WriteLine("Digite 3 - Multiplicação");

    //        Console.WriteLine("Digite 4 - Divisão ");



    //        Console.WriteLine("Digite um numero: ");
    //        N = int.Parse(Console.ReadLine());



    //        Console.WriteLine("Digite o primeiro valor: ");
    //        A = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Digite o segundo valor: ");
    //        B = int.Parse(Console.ReadLine());

    //        string resultado = Calculo(N, A, B);
    //        Console.WriteLine($"O resultado é: {resultado}");

    //    }

    //    public static string Calculo(int N, int A, int B)
    //    {
    //        if (N == 1)
    //        {

    //            return (A + B).ToString();

    //        }
    //        else if (N == 2)
    //        {
    //            return (A - B).ToString();

    //        }
    //        else if (N == 3)
    //        {

    //            return (A * B).ToString();
    //        }
    //        else if (N == 4)
    //        {
    //            if (B != 0)
    //            {
    //                return ((float)A / B).ToString();
    //            }
    //            else
    //            {
    //                return "Não é Possivel dividir por zero";
    //            }
    //        }
    //        else
    //        {
    //            return "Opção incorreta";
    //        }
    //    }
    //}


    //4

    //    public static void Main(string[] args)
    //    {

    //        Console.WriteLine("Escreva um Numero");
    //        int N = int.Parse(Console.ReadLine());

    //        string resultado = Calculo(N);

    //        Console.WriteLine(resultado);

    //    }

    //    public static string Calculo(int N)
    //    {
    //        if (N % 2 != 0)
    //        {
    //            return "Impar";
    //        }
    //        else
    //        {
    //            return "Par";
    //        }

    //    }
    //}

    //5

//    public static void Main(string[] agrs)
//    {
//        Console.WriteLine("Escreva um Numero inteiro: ");
//        int N = int.Parse(Console.ReadLine());

//        string resultado = calculo(N);

//        Console.WriteLine(resultado);

//    }

//    public static string calculo(int N)
//    {
//        {
//            if (N <= 1)
//                return "false";

//            if (N <= 3)
//                return "true";

//            if (N % 2 == 0 || N % 3 == 0)
//                return "false";

//            for (int i = 5; i * i <= N; i += 6)
//            {
//                if (N % i == 0 || N % (i + 2) == 0)
//                    return "false";
//            }

//            return "true";
//        }

//    }
}