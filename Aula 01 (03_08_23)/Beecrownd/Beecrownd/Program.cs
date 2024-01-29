class Program
{
    static void Main(string[] args)
    {
        int N;
        do
        {

            Console.WriteLine("Digite um Numero Inteiro: ");
            N = int.Parse(Console.ReadLine());

        } while (N <= 1 || N >= 1000);

        Console.Clear();

        Calculo(N);

        
    } static void Calculo(int N)
    {

        for (int i = 1; i <= N; i++)
        {
            int A,B,C,D;

            A = i * i;

            B = i * i * i;

            Console.WriteLine($"{i} {A} {B}" );

            C = A +1; 
            D = B +1;

            Console.WriteLine($"{i} {C} {D}");
        } 
    }
}   