using System;

class Program
{
    class Triangulo
    {
        private int lado1 = 10;
        private int lado2 = 10;
        private int lado3 = 10;

        public Triangulo(string info)
        {
            Console.WriteLine(info);
        }

        public int TamanhoLado1
        {
            set { this.lado1 = value; }
        }

        public int TamanhoLado2
        {
            set { this.lado2 = value; }
        }

        public int TamanhoLado3
        {
            set { this.lado3 = value; }
        }

        public void MostraLados()
        {
            Console.WriteLine("Lado 1 = {0}", lado1);
            Console.WriteLine("Lado 2 = {0}", lado2);
            Console.WriteLine("Lado 3 = {0}", lado3);
            Console.WriteLine();
            Console.ReadKey();
        }

        public void AlteraDados(int lado1)
        {
            this.lado1 = lado1;
        }

        public int Retorna
        {
            get { return this.lado1; }
        }
    }

    static void Main(string[] args)
    {
        Triangulo a = new Triangulo("Equilatero")
        {
            TamanhoLado1 = 12,
            TamanhoLado2 = 12,
            TamanhoLado3 = 12
        };

        a.MostraLados();
        a.AlteraDados(25);
        a.MostraLados();
        Console.WriteLine(a.Retorna);
        Console.ReadKey();
    }
}
