//Anotações

// recursividade e um laço em memoria ram
// qualquer programa que for executar, o que eu faço com a recursividade eu faço sem ela
// quando um bloco chama a si mesmo e uma chamada direta e quando ele chama outro e uma chama indireta
//
//class program
//{

//    static int Fatorial(int x)
//    {
//        if (x == 1) return (1);
//        {
//            return (x * Fatorial(x - 1));
//        }
//    }

//    static void Main(string[] args)
//    {
//        int num = 5;
//        Console.WriteLine("A soma é {0}",Fatorial(num));
//        Console.ReadKey();
//    }
//}

class program
{
    public static int potencial(int num, int pot)
    {
        if (pot == 0)
        {
            return 1;
        }

        return num * potencial(num, pot-1);
    }

    static void Main(string[] args)
    {
        int num, pot;
        Console.Write("Digite a base: ");
        num = int.Parse(Console.ReadLine());
        Console.Write("Digite a potencia ");
        pot = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} elevado a {1} é {2}", num, pot, potencial(num, pot));
        Console.ReadKey();
    }
}