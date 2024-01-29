class program
{


    //public static void Main(string[] args)
    //{

    //    Console.WriteLine("Digite um numero inteiro: ");
    //    int num = int.Parse(Console.ReadLine());

    //    Calculo(n);

    //    Console.WriteLine(Calculo(num));
    // }

    // static int Calculo(int num)
    //{
    //    if (num == 1) return 1;
    //    else
    //    return num + Calculo(num - 1);
    //}




    static void Main(String[] args)
{
    int[] n = { 3, 2, 5, 4, 1 };



    int nmax = vetor(n, 0, n[0]);

    Console.WriteLine("o maior elemento é: " + nmax);


}

static int vetor(int[] n, int max, int Q)
{
    if (Q >= n.Length)
        return max;
    if (n[Q] > max)
        max = n[Q];

    return vetor(n, Q + 1, max);
}
}



