//exercicio1
//class program
//{
//    class Ingresso
//    {
//        public float Reais = 32;
//        public void ImprimiValor()
//        {
//            Console.WriteLine(Reais);

//        }
//        public class VIP : Ingresso
//        {
//            public float valorAdicional { get; set; }
//            public float ImprimiValorAdc()
//            {
//                valorAdicional = 100;
//                return Reais + valorAdicional;
//            }
//        }
//        public class Normal : Ingresso
//        {
//            public float ingressoNormal { get; set; }
//            public float IngressoNormal()
//            {
//                ingressoNormal = Reais;
//                return Reais;
//            }
//        }
//        public class CamaroteInferior : VIP
//        {
//            public string LocalizacaoIngresso = "Setor 5 Seção 2";
//            public float ValorADD { get; set; }
//            public float ValorCamaroteInf()
//            {
//                float ValorADD = 55;

//                return (ValorADD + Reais);

//            }
//        }
//        public class CamaroteSuperior : VIP
//        {
//            public float ValorAdc { get; set; }
//            public float RetornarValor()
//            {
//                ValorAdc = 45;
//                return Reais + ValorAdc;

//            }
//        }
//        static void Main(string[] Args)
//        {

//            Normal ticket = new Normal();
//            VIP vip = new VIP();
//            CamaroteSuperior camaroteSUP = new CamaroteSuperior();
//            CamaroteInferior camaroteINF = new CamaroteInferior();

//            ticket.ingressoNormal = ticket.IngressoNormal();
//            Console.WriteLine("O valor do Ingresso Normal é: {0}", ticket.IngressoNormal());

//            vip.valorAdicional = vip.ImprimiValorAdc();
//            Console.WriteLine("O valor do VIP é: {0}", vip.ImprimiValorAdc());

//            camaroteSUP.ValorAdc = camaroteSUP.RetornarValor();
//            Console.WriteLine("O valor do Camarote Superior é: {0}", camaroteSUP.ValorAdc);

//            camaroteINF.ValorADD = camaroteINF.ValorCamaroteInf();
//            Console.WriteLine("O valor do Camarote Inferior é: {0} Com localizaçao: {1}", camaroteINF.ValorCamaroteInf(), camaroteINF.LocalizacaoIngresso);
//        }
//    }
//}

//Exercicio 2 

//class program
//{

//    class Imovel
//    {

//        public string Endereço = "Rua São Luiz";
//        public float preco = 300.000f;

//        class Novo : Imovel
//        {

//            public float AddValor { get; set; }

//            public float ValorADD()
//            {
//                AddValor = 500.000f;
//                return AddValor + preco;

//            }


//        }

//        class Velho : Imovel
//        {

//            public float Desconto { get; set; }

//            public float ValorDesconto()
//            {

//                Desconto = 100.000f;
//                return preco - Desconto;


//            }


//        }


//        static void Main(string[] Args)
//        {

//            Imovel Imovel = new Imovel();
//            Novo novo = new Novo();
//            Velho velho = new Velho();

//            Console.WriteLine($" O valor do Imóvel no endereço {Imovel.Endereço} é: R$ {Imovel.preco:F3}");

//            Console.WriteLine($" O valor da casa nova é: R$ {novo.ValorADD():F3}");

//            Console.WriteLine($" O valor da casa velha é: R$ {velho.ValorDesconto():F3}");


//        }

//    }


//}