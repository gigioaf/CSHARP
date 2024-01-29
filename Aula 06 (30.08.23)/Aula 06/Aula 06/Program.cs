//softwarehouse: Compra de produtos prontos pra implementação.

//programaçao de cauda.

//fabrica de software: Desenvolve do 0 um software especifico.

// todo objeto deriva de uma classe.

// uma classe é um modelo, logo n pode ser usada diretamente.

//a classe é utilizada apenas para criar objetos que são utilizados.

// O ato de criar um objeto a partir de uma classe e chamado de instanciação.

// toda vez que uma variavel e do tipo classe armazena endereço de memoria de objeto.

// toda vez que um metodo tem o mesmo nome que uma classe ele é chamada de construtor


class program
{

    class Circle
    {
        private int raio;

        public Circle()         // construtor padrão
        {
            raio = 2;

        }

        public double Area(int raio)
        {
            return (Math.PI * raio * raio);
        }

    }

    static void Main(string[] args)
    {
        Circle c;            //Cria uma  variavel da classe Circle
        c = new Circle();   // inicializa a variavel
        double areadocirculo;
        int raio = 4;

        areadocirculo = c.Area(raio);
        Console.WriteLine(areadocirculo);
        Console.ReadKey();



    }
}
