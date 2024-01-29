//EX - 01
//class program
//{
//    public class Alunos
//    {
//        private string matricula;
//        private string nome;
//        private float prova1;
//        private float prova2;
//        private float TrabalhoP;
//        public Alunos(string m, string n, float p1, float p2, float TP)
//        {
//            this.matricula = m;
//            this.nome = n;
//            this.prova1 = p1;
//            this.prova2 = p2;
//            this.TrabalhoP = TP;
//        }
//        public void gravarMatricula(string m)
//        {
//            matricula = m;
//        }
//        public string getMatricula()
//        {
//            return (matricula);
//        }
//        public void gravarNome(string n)
//        {
//            nome = n;
//        }
//        public string getNome()
//        {
//            return (nome);
//        }
//        public void gravarProva1(float p1)
//        {
//            prova1 = p1;
//        }
//        public float getProva1()
//        {
//            return (prova1);
//        }
//        public void gravarProva2(float p2)
//        {
//            prova2 = p2;
//        }
//        public float getProva2()
//        {
//            return (prova2);
//        }
//        public void gravarTrabalhoP(float TP)
//        {
//            TrabalhoP = TP;
//        }
//        public float getTrabalhoP()
//        {
//            return (TrabalhoP);
//        }
//        public float Media()
//        {
//            return ((prova1 * 2.5f) + (prova2 * 2.5f) + (TrabalhoP *
//            2f)) / 7f;
//        }
//        public float Final()
//        {
//            float media = Media();
//            if (media < 7)
//            {
//                return 7 - media;
//            }
//            else
//            {
//                return 0;
//            }
//        }
//    }
//    static void Main(string[] args)
//    {
//        Alunos aluno = new Alunos("223671", "Giovanne", 2.0f, 3.0f,
//        3.0f);
//        Console.WriteLine("Matrícula: " + aluno.getMatricula());
//        Console.WriteLine("Nome: " + aluno.getNome());
//        Console.WriteLine("Nota P1: {0} ", aluno.getProva1());
//        Console.WriteLine("Nota P2: {0} ", aluno.getProva2());
//        Console.WriteLine("Nota TP: {0}", aluno.getTrabalhoP());
//        Console.WriteLine("Media: {0}", aluno.Media());
//        Console.WriteLine("Falta: {0}", aluno.Final());
//        Console.WriteLine("------------------------------------");
//        Alunos aluno2 = new Alunos("215678", "Pedro", 10.0f, 5.0f,
//        7.0f);
//        Console.WriteLine("Matrícula: " + aluno2.getMatricula());
//        Console.WriteLine("Nome: " + aluno2.getNome());
//        Console.WriteLine("Nota P1: {0} ", aluno2.getProva1());
//        Console.WriteLine("Nota P2: {0} ", aluno2.getProva2());
//        Console.WriteLine("Nota TP: {0}", aluno2.getTrabalhoP());
//        Console.WriteLine("Media: {0}", aluno2.Media());
//        Console.WriteLine("Falta: {0}", aluno2.Final());
//        Console.ReadKey();
//        Console.Clear();
//    }
//}

//EX - 02

//using static program;

//class program
//{
//    public class Datas
//    {
//        private int dia;
//        private int mes;
//        private int ano;
//        private string mesexte;
//        public Datas
//        (int d, int m, int a, string me)
//        {
//            this.dia = d;
//            this.mes = m;
//            this.ano = a;
//            this.mesexte = me;
//        }
//        public void gravarDia(int d)
//        {
//            dia = d;
//        }
//        public int getDia()
//        {
//            return dia;
//        }
//        public void gravarMes(int m)
//        {
//            mes = m;
//        }
//        public int getMes()
//        {
//            return mes;
//        }
//        public void gravarAno(int a)
//        {
//            ano = a;
//        }
//        public int getAno()
//        {
//            return ano;
//        }
//        public void gravarMesExt(string me)
//        {
//            mesexte = me;
//        }
//        public string getMesExt()
//        {
//            return mesexte;
//        }
//        public Boolean isBissexto()
//        {
//            int year = ano;
//            if (year % 4 == 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//    static void Main(string[] agrs)
//    {
//        Datas data = new Datas(28, 06, 2004, "Junho");
//        Console.WriteLine("Dia: {0}/{1}/{2}", data.getDia(),
//       data.getMes
//        (), data.getAno());
//        Console.WriteLine("Mes Extenso: {0} ", data.getMesExt());
//        Console.WriteLine("Ano Bissexto: {0} ", data.isBissexto());
//        Console.WriteLine

//       ("---------------------------------------------------------");
//        Datas dataclone = new Datas(28, 06, 2004, "Junho");
//        Console.WriteLine("Dia: {0}/{1}/{2}", dataclone.getDia(),
//        dataclone.getMes(), dataclone.getAno());
//        Console.WriteLine("Mes Extenso: {0} ", dataclone.getMesExt
//        ());
//        Console.WriteLine("Ano Bissexto: {0} ", dataclone.isBissexto
//       ());
//    }
//}
