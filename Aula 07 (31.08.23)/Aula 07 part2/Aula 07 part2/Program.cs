class Program
{
    class aluno
    {
        string nome;
        
        public aluno (string n)         //Método construtor
        {
            nome = n;
        }
     
        public void GravaNome(string n)        //Insere o valor no atributo
        {
            nome = n;
        }
        
        public string getNome()         //Método de retorna o valor do atributo
        {
            return (nome);
        }
    }
    static void Main (string [] args)
    {
        aluno alu = new aluno("Carlos");
        Console.WriteLine("Nome do aluno é {0} ", alu.getNome());
        Console.ReadKey();

        alu.GravaNome("Pedro");
        Console.WriteLine("Nome do aluno agora é {0} ", alu.getNome());
        Console.ReadKey ();
    }
}