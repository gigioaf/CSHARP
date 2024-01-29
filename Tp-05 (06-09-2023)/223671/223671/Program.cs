//EX - 01

//class Program
//{
//    class Funcionario
//    {

//        private string nome;

//        public Funcionario()
//        {

//            Console.Write("Digite o nome do funcionário: ");
//            nome = Console.ReadLine();


//        }



//        public string getNome()
//        {

//            return nome;

//        }

//    }

//    class Salario
//    {

//        private double value;

//        public Salario()


//        {

//            Console.Write("Digite o sálario do funcionário: ");
//            this.value = double.Parse(Console.ReadLine());

//        }

//        public double getValue()

//        {

//            return value;

//        }

//    }

//    static void Main(string[] args)
//    {


//        Funcionario novo = new Funcionario();
//        Console.WriteLine("O nome do funcionário é: " + novo.getNome());
//        Console.ReadKey();

//        Salario novo1;
//        novo1 = new Salario();
//        Console.WriteLine("O Salário de {0} é: {1}", novo.getNome(), novo1.getValue());
//        Console.ReadKey();

//    }

//}

//Ex - 02

//class Program
//{
//    class Funcionario
//    {
//        private string nome;
//        private int salario;

//        public Funcionario(string nome, int salario)
//        {
//            this.nome = nome;
//            this.salario = salario;
//            Console.WriteLine("Os dados do seguinte funcionário é:");

//            Console.WriteLine("\nNome: {0}\nMédia Salarial: R${1} por mês", this.nome, this.salario);
//        }
//    }
//    static void Main(string[] args)
//    {
//        Funcionario valor;
//        valor = new Funcionario("Marley", 5000);
//        Console.ReadKey();
//    }
//}


//Ex - 03


//class Program
//{
//    class NotaFiscal
//    {
//        private string nome;
//        private int fatura, quantidade;
//        private double preco, total;

//        public NotaFiscal(string nome, int fatura, int quantidade, double preco)
//        {
//            this.nome = nome;
//            this.fatura = fatura;
//            this.quantidade = quantidade;
//            this.preco = preco;

//            Console.WriteLine("O item {0} sob o código {1}, custa: R${2} por unidade", this.nome, this.fatura, this.preco);
//            Console.WriteLine("\nDigite a quantidade desejada para o produto {0}", this.nome);
//            this.quantidade = int.Parse(Console.ReadLine());
//            this.total = GetInvoiceAmount(this.quantidade, this.preco);
//            Console.WriteLine("\nO valor total de {0} unidades é de: R${1}", this.quantidade, this.total);
//        }

//        public double GetInvoiceAmount(int quantidade, double preco)
//        {
//            return (quantidade * preco);
//        }
//    }

//    static void Main(string[] args)
//    {
//        NotaFiscal descricao;
//        descricao = new NotaFiscal("PC GAMER", 882313, 1, 9250.00);
//    }
//}

//EX - 04

//class program
//{
//    public class pessoa
//    {
//        private string nome;
//        private int idade;
//        private float altura;
//        private float peso;

//        public pessoa(string n, int i, float a, float p)
//        {
//            this.nome = n;
//            this.idade = i;
//            this.altura = a;
//            this.peso = p;
//        }
//        public void gravarNome(string n)
//        {
//            nome = n;

//        }
//        public string getNome()
//        {
//            return (nome);

//        }
//        public void gravarIdade(int i)
//        {
//            idade = i;
//        }
//        public int getIdade()
//        {
//            return (idade);
//        }
//        public void gravarAltura(float a)
//        {
//            altura = a;
//        }

//        public float getAltura()
//        {
//            return (altura);
//        }
//        public void gravarPeso(float p)
//        {
//            peso = p;
//        }
//        public float getPeso()
//        {
//            return (peso);
//        }


//    }
//    static void Main(string[] args)
//    {
//        pessoa Pessoa = new pessoa("Lucas", 20, 1.84f, 78.15f);
//        Console.WriteLine("Nome: " + Pessoa.getNome());
//        Console.WriteLine("Idade: " + Pessoa.getIdade());
//        Console.WriteLine("Altura:{0} M", Pessoa.getAltura());
//        Console.WriteLine("Peso:{0} Kg", Pessoa.getPeso());

//        Console.ReadKey();
//        Console.Clear();

//        Pessoa.gravarNome("Léo");
//        Pessoa.gravarIdade(19);
//        Pessoa.gravarAltura(1.83f);
//        Pessoa.gravarPeso(78.50f);

//        Console.WriteLine("Dados atualizados");

//        Console.WriteLine("Nome: " + Pessoa.getNome());
//        Console.WriteLine("Idade: " + Pessoa.getIdade());
//        Console.WriteLine("Altura:{0} M", Pessoa.getAltura());
//        Console.WriteLine("Peso:{0} Kg", Pessoa.getPeso());
//    }
//}

//EX - 05
//class program
//{
//    public class pessoa
//    {
//        private string nome;
//        private int idade;
//        private float altura;
//        private float peso;

//        public pessoa(string n, int i, float a, float p)
//        {
//            this.nome = n;
//            this.idade = i;
//            this.altura = a;
//            this.peso = p;
//        }
//        public void gravarNome(string n)
//        {
//            nome = n;

//        }
//        public string getNome()
//        {
//            return (nome);

//        }
//        public void gravarIdade(int i)
//        {
//            idade = i;
//        }
//        public int getIdade()
//        {
//            return (idade);
//        }
//        public void gravarAltura(float a)
//        {
//            altura = a;
//        }

//        public float getAltura()
//        {
//            return (altura);
//        }
//        public void gravarPeso(float p)
//        {
//            peso = p;
//        }
//        public float getPeso()
//        {
//            return (peso);
//        }

//        public string IMC(float imc)
//        {
//            imc = peso / (altura * altura);


//            if (imc < 20)
//            {
//                return "Abaixo do peso".ToString();

//            }
//            else if (imc > 20 && imc <= 25)
//            {
//                return "Peso normal".ToString();
//            }
//            else if (imc > 25 && imc <= 30)
//            {
//                return "Sobrepeso".ToString();
//            }
//            else if (imc > 30 && imc <= 35)
//            {
//                return "Obesidade grau I".ToString();
//            }
//            else if (imc > 35 && imc <= 40)
//            {
//                return "Obesidade grau II".ToString();
//            }
//            else if (imc > 40)
//            {
//                return "Obesidade grau III".ToString();
//            }
//            else
//            {
//                return imc.ToString();
//            }
//        }

//    }
//    static void Main(string[] args)
//    {
//        pessoa Pessoa = new pessoa("Giovanne", 19, 1.78f, 52.15f);
//        Console.WriteLine("Nome: " + Pessoa.getNome());
//        Console.WriteLine("Idade: " + Pessoa.getIdade());
//        Console.WriteLine("Altura:{0} M", Pessoa.getAltura());
//        Console.WriteLine("Peso:{0} Kg", Pessoa.getPeso());
//        Console.WriteLine("Categoria: {0}", Pessoa.IMC(1));



//        Console.ReadKey();
//        Console.Clear();

//        Pessoa.gravarNome("Leonardo");
//        Pessoa.gravarIdade(19);
//        Pessoa.gravarAltura(1.83f);
//        Pessoa.gravarPeso(78.50f);

//        Console.WriteLine("Dados atualizados");

//        Console.WriteLine("Nome: " + Pessoa.getNome());
//        Console.WriteLine("Idade: " + Pessoa.getIdade());
//        Console.WriteLine("Altura:{0} M", Pessoa.getAltura());
//        Console.WriteLine("Peso:{0} Kg", Pessoa.getPeso());
//        Console.WriteLine("Categoria: {0}", Pessoa.IMC(1));
//    }
//}