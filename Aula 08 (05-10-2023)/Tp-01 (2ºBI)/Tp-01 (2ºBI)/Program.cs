//1
//class Program
//{
//    class Produto
//    {
//        public string L { get; set; } = "Leite";
//        public float LP { get; set; } = 5.25f;
//        public string S { get; set; } = "Sabão";
//        public float SP { get; set; } = 2.50f;

//        public Produto(string info)
//        {
//            Console.WriteLine(info);
//        }

//        public void MostrarProdutos()
//        {
//            Console.WriteLine("Nome do Produto: {0}", L);
//            Console.WriteLine("Preço do Produto: {0}", LP);
//        }

//        public float Calculo(int Q)
//        {
//            return Q * LP;
//        }
//    }

//    class CarrinhoDeCompras
//    {
//        public string L { get; set; }
//        public int Q { get; set; }
//    }

//    static void Main(string[] args)
//    {
//        Produto produto = new Produto("Informações do Produto");
//        produto.MostrarProdutos();

//        CarrinhoDeCompras carrinhoDeCompras = new CarrinhoDeCompras();

//        Console.WriteLine("Digite o Nome do Produto");
//        carrinhoDeCompras.L = Console.ReadLine();

//        Console.WriteLine("Digite a Quantidade");
//        carrinhoDeCompras.Q = int.Parse(Console.ReadLine());

//        Console.Clear();

//        float total = produto.Calculo(carrinhoDeCompras.Q);

//        Console.WriteLine($"Produto no Carrinho: {carrinhoDeCompras.L}");
//        Console.WriteLine ($"Quantidade no Carrinho: {carrinhoDeCompras.Q}");
//        Console.WriteLine($"Total da compra: R$ {total:F2}");
//    }
//}

//2

//class Program
//{
//    class Tarefa
//    {
//        private string descricao;
//        private string datacriacao;
//        private bool status;
//        public Tarefa(string d, string dc, bool s)
//        {
//            this.descricao = d;
//            this.datacriacao = dc;
//            this.status = s;
//        }
//        public void Setdescricao(string dc)
//        {
//            descricao = dc;
//        }
//        public string getdescricao()
//        {
//            return (descricao);
//        }
//        public string Atribuirdata
//        {
//            set { this.datacriacao = value; }
//        }
//        public string Retornadata
//        {
//            get { return this.datacriacao; }
//        }
//        public bool Atribuirstatus
//        {
//            set { this.status = value; }
//        }
//        public bool Retornastatus
//        {
//            get { return this.status; }
//        }
//        public void MarcarComoConcluida()
//        {
//            status = true;
//        }
//        public bool EstaConcluida()
//        {
//            return status;
//        }
//        public void ExibirInformacoes()
//        {
//            string statusDescricao;
//            if (status)
//            {
//                statusDescricao = "Concluída";
//            }
//            else
//            {
//                statusDescricao = "Não Concluída";
//            }
//            Console.WriteLine("Descrição: " + getdescricao());
//            Console.WriteLine("Data de Criação: " + Retornadata);
//            Console.WriteLine("Status: " + statusDescricao);
//        }
//    }
//    static void Main(string[] args)
//    {
//        Tarefa a = new Tarefa("Limpar a casa", "08/12/2023", true);
//        a.ExibirInformacoes();
//        a.MarcarComoConcluida();
//    }

//}