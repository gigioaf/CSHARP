// Exemplo 01
//namespace Polimorfismo_Ex02
//{

    /*    Exemplo de como utilizar o polimorfismo de sobrecarga em linguagem C#    */

    // O polimorfismo de sobrecarga em C# permite que você defina vários métodos com o mesmo nome     
    // em uma classe, mas com diferentes parâmetros. A sobrecarga de método é determinada em tempo de    
    // compilação ou tempo de execução com base nos argumentos passados na chamada do método.
    // Numa classe e posso ter varios metodos com mesmo nome, porém com uma quantidade diferentes de argumentos (assinaturas)

    //    class Calculadora
    //    {
    //        public int Somar(int a, int b)
    //        {
    //            return (a + b);
    //        }
    //        public double Somar(double a, double b)
    //        {
    //            return (a + b);
    //        }
    //        public string Somar(string a, string b)
    //        {
    //            return (a + b);
    //        }
    //    }
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Calculadora calc = new Calculadora();
    //            int resultadoInt = calc.Somar(5, 3);
    //            double resultadoDouble = calc.Somar(2.5, 1.5);
    //            string resultadoString = calc.Somar("Olá, ", "mundo!");
    //            Console.WriteLine("Soma de inteiros: " + resultadoInt);
    //            Console.WriteLine("Soma de doubles: " + resultadoDouble);
    //            Console.WriteLine("Concatenação de strings: " + resultadoString);
    //            Console.ReadKey();
    //        }
    //    }
    //}
    // Neste exemplo, a classe `Calculadora` possui três métodos `Somar` com o mesmo nome,     
    // mas com diferentes tipos de argumentos(int, double e string).    
    // Quando você chama o método `Somar`, o C# determina qual versão do método usar com base nos tipos dos argumentos passados.    
    // Isso demonstra como o polimorfismo de sobrecarga permite que você tenha métodos  com o mesmo nome, mas que realizam operações
    // diferentes com base nos tipos de argumentos passados.

    //Exemplo 02

//    namespace Polimorfismo_Ex04
//    {
//        using System;
//        class ProcessadorImagem
//        {
//            // Método de sobrecarga para aplicar um filtro de brilho à imagem
//            public void AplicarFiltro(string imagem, int brilho)
//            {
//                Console.WriteLine($"Aplicando filtro de brilho {brilho} à imagem: {imagem}");
//                // Lógica de aplicação do filtro de brilho
//            }
//            // Método de sobrecarga para aplicar um filtro de saturação à imagem
//            public void AplicarFiltro(string imagem, double saturacao)
//            {
//                Console.WriteLine($"Aplicando filtro de saturação {saturacao} à imagem: {imagem}");
//                //Lógica de aplicação do filtro de saturação
//            }
//            // Método de sobrecarga para aplicar um filtro de nitidez à imagem
//            public void AplicarFiltro(string imagem, int nitidez, double contraste)
//            {
//                Console.WriteLine($"Aplicando filtro de nitidez {nitidez} e contraste {contraste} à imagem: {imagem}");
//                // Lógica de aplicação do filtro de nitidez
//            }
//        }
//        class Program
//        {
//            static void Main()
//            {
//                ProcessadorImagem processador = new ProcessadorImagem();
//                processador.AplicarFiltro("imagem1.jpg", 20);
//                processador.AplicarFiltro("imagem2.jpg", 1.5);
//                processador.AplicarFiltro("imagem3.jpg", 10, 1.2);
//                Console.ReadKey();
//            }
//        }
//    }
//}
