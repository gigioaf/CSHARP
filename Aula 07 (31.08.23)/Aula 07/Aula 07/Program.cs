class program
{
    class Point
    {
        public int x,y;

        public Point()
        {
            Console.WriteLine("Metodo Construtor chamado...");

        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

            Console.WriteLine("os valores das variaveis" + "são x: {0} e y: {1}", this.x, this.y);

        }
    }

    static void Main (string[] args)
    {
        Point valor;
        valor = new Point();
        Console.ReadKey();

        Console.Clear();
        valor = new Point(2,3);
        Console.ReadKey();
    }
}