class Program
{
    class graduacao
    {
        public string nome { get; set; }
        public int matricula { get; set; }
        public int codigo { get; set; }

        public float CalcularMensalidade()
        {
            float mensalidade = 0;

            switch (codigo)
            {
                case 1:
                    mensalidade = 450.00f;
                    break;
                case 2:
                    mensalidade = 650.00f;
                    break;
                case 3:
                    mensalidade = 850.00f;
                    break;
                case 4:
                    mensalidade = 750.00f;
                    break;
                default:
                    Console.WriteLine("Código de curso inválido.");
                    break;
            }
            return mensalidade;
        }
    }
    class Pos : graduacao
    {
        public string LinhaPesquisa { get; set; }
        public string Orientador { get; set; }
        public float BolsaEstudos { get; set; }

        public float CalcularMensalidadeDesc(float bau)
        {

            return bau - BolsaEstudos;

        }
    }

    static void Main(string[] Agrs)
    {
        int grad;
        graduacao Graduacao = new graduacao();
        Pos posgrad = new Pos();

        do
        {
            Console.Clear();
            Console.WriteLine("1 - Graduacão");
            Console.WriteLine("2 - Pos-Graduacão");
            Console.WriteLine("3 - Sair");

            grad = int.Parse(Console.ReadLine());

            switch (grad)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Entre com o nome: ");
                    Graduacao.nome = (Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Entre com o matricula: ");
                    Graduacao.matricula = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine(" ____________________");
                    Console.WriteLine("|                    |");
                    Console.WriteLine("|   Tipos de Curso   |");
                    Console.WriteLine("|____________________|");
                    Console.WriteLine("1 - Arquitetura");
                    Console.WriteLine("2 - Sistema de Informacao");
                    Console.WriteLine("3 - Engenharia");
                    Console.WriteLine("4 - BioMedicina");
                    Console.WriteLine();

                    Console.WriteLine("Entre com o codigo de curso: ");
                    Graduacao.codigo = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Nome: {0}", Graduacao.nome);
                    Console.WriteLine("Matricula: {0}", Graduacao.matricula);
                    Console.WriteLine("Codigo de curso: {0}", Graduacao.codigo);
                    Console.WriteLine("Mensalidade: R${0}", Graduacao.CalcularMensalidade());
                    Console.ReadKey();

                    break;

                case 2:
                    Console.Clear();

                    Console.WriteLine("Entre com o nome: ");
                    Graduacao.nome = (Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Entre com o matricula: ");
                    Graduacao.matricula = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine(" _____________________");
                    Console.WriteLine("|                    |");
                    Console.WriteLine("|   Tipos de Curso   |");
                    Console.WriteLine("|____________________|");
                    Console.WriteLine("1 - Arquitetura");
                    Console.WriteLine("2 - Sistema de Informacao");
                    Console.WriteLine("3 - Engenharia");
                    Console.WriteLine("4 - BioMedicina");
                    Console.WriteLine();


                    Console.WriteLine("Entre com o codigo de curso: ");
                    Graduacao.codigo = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Entre com o valor da bolsa de estudos: ");
                    posgrad.BolsaEstudos = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Entre com o nome do orientador: ");
                    posgrad.Orientador = (Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Entre com a linha de pesquisa: ");
                    posgrad.LinhaPesquisa = (Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Nome: {0}", Graduacao.nome);
                    Console.WriteLine("Matricula: {0}", Graduacao.matricula);
                    Console.WriteLine("Codigo de curso: {0}", Graduacao.codigo);
                    Console.WriteLine("Mensalidade: R${0}", Graduacao.CalcularMensalidade());

                    float bau = Graduacao.CalcularMensalidade();
                    Console.WriteLine("Mensalidade com desconto: R${0}", posgrad.CalcularMensalidadeDesc(bau));

                    Console.WriteLine("Orientador: {0}", posgrad.Orientador);
                    Console.WriteLine("Linha de pesquisa: {0}", posgrad.LinhaPesquisa);
                    Console.ReadKey();
                    break;
            }
        } while (grad != 3);

    }
}