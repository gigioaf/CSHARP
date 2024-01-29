class CalculoDeArea
{

    public int Calculo (int a, int b)
    {
        return a * b;
    }

    public float Calculo (float a, float b)
    {
        return (a * b) / 2;
    }

    public double Calculo (double a, double b)
    {
        float raio = (float)(b * b);
        return (float)(a * raio);

    }

    class program
    {
        static void Main(string[] args)
        
        
        {
            CalculoDeArea calc = new CalculoDeArea();

            int resultInt = calc.Calculo(4, 2);
            float resultFloat = calc.Calculo(2.5f, 4.5f);
            double resultDouble= calc.Calculo(3.14, 4);

            Console.WriteLine("Area de um Retangulo: {0} ", resultInt);
            Console.WriteLine($"Area de um triangulo: {resultFloat:f2} ");
            Console.WriteLine($"Area de um Circulo: {resultDouble:f2} ");


        }

        
    }

}