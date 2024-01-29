class JogoDaVelha
{
    private bool fimDejogo;
    private char[] posicoes;
    private char vez;
    private int quantidadeP;

    public JogoDaVelha()
    {
        fimDejogo = false;
        posicoes = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        vez = 'X';
        quantidadeP = 0;
    }

    public void start()
    {
        while (!fimDejogo)
        {
            DesenharTabela();
            EscolhaDoUsuario();
            DesenharTabela();
            VerificarFinal();
            MudarVez();
        }

    }

    private void MudarVez()
    {
        if (vez == 'X')
        {
            vez = 'O';
        }
        else
            vez = 'X';
    }

    private void VerificarFinal()
    {
        if (quantidadeP < 5)
        {
            return;
        }

        if (VitoriaDiagonal() || VitoriaVertical() || VitoriaHorizontal())
        {
            fimDejogo = true;
            Console.WriteLine($"Fim de Jogo!! vitoria de {vez}");
            return;
        }

        if (quantidadeP == 9)
        {
            fimDejogo = true;
            Console.WriteLine("Deu velha");

        }


    }

    private bool VitoriaHorizontal()
    {

        bool linha1 = posicoes[0] == posicoes[1] && posicoes[0] == posicoes[2];
        bool linha2 = posicoes[3] == posicoes[4] && posicoes[3] == posicoes[5];
        bool linha3 = posicoes[6] == posicoes[7] && posicoes[6] == posicoes[8];

        return linha1 || linha2 || linha3;
    }

    private bool VitoriaVertical()
    {
        bool linha1 = posicoes[0] == posicoes[3] && posicoes[0] == posicoes[6];
        bool linha2 = posicoes[1] == posicoes[4] && posicoes[1] == posicoes[7];
        bool linha3 = posicoes[2] == posicoes[5] && posicoes[2] == posicoes[8];

        return linha1 || linha2 || linha3;

    }

    private bool VitoriaDiagonal()
    {
        bool linha1 = posicoes[6] == posicoes[4] && posicoes[6] == posicoes[2];
        bool linha2 = posicoes[0] == posicoes[4] && posicoes[0] == posicoes[8];

        return linha1 || linha2;

    }


    private void EscolhaDoUsuario()
    {
        Console.WriteLine($"agora é a vez de {vez}, Digite entre uma posicção de 1 a 9 correspondente a tabela");

        bool conversao = int.TryParse(Console.ReadLine(), out int posicaoSelecionada);

        while (!conversao || !ValidarEscolha(posicaoSelecionada))
        {
            Console.WriteLine("Valor digitado invalido (Digite entre 1 e 9, que esteja livre)");
            conversao = int.TryParse(Console.ReadLine(), out posicaoSelecionada);
        }

        ExecutarEscolha(posicaoSelecionada);

    }
    private void ExecutarEscolha(int posicaoSelecionada)
    {
        int indice = posicaoSelecionada - 1;

        posicoes[indice] = vez;
        quantidadeP++;

    }

    private bool ValidarEscolha(int posicaoSelecionada)
    {
        int indice = posicaoSelecionada - 1;

        if (posicoes[indice] == 'O' || posicoes[indice] == 'X')
        {

            return false;

        }
        else
            return true;
    }

    private void DesenharTabela()
    {
        Console.Clear();

        Console.WriteLine(Tabela());
    }

    private string Tabela()
    {
        return $"___{posicoes[0]}___|___{posicoes[1]}___|___{posicoes[2]}___\n" +
               $"___{posicoes[3]}___|___{posicoes[4]}___|___{posicoes[5]}___\n" +
               $"   {posicoes[6]}   |   {posicoes[7]}   |   {posicoes[8]}  ";
    }


    static void Main(string[] args)
    {
        new JogoDaVelha().start();
    }
}

