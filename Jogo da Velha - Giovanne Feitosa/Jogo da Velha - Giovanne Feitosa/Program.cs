class JogoDaVelha
{
    private bool fimDejogo;
    private char[] posicoes;
    private char vez;
    private int quantidadeP;
    private char vencedor;

    public JogoDaVelha()
    {
        fimDejogo = false;
        posicoes = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        vez = 'X';
        quantidadeP = 0;
        vencedor = ' ';
    }

    public void start()
    {
        while (!fimDejogo)
        {
            DesenharTabela();
            EscolhaDoUsuario();
            VerificarFinal();
            MudarVez();
        }

        Console.WriteLine("Fim de Jogo!");
        if (vencedor != ' ')
        {
            Console.WriteLine($"Vitória de {vencedor}!");
        }
        else
        {
            Console.WriteLine("Deu velha");
        }
    }

    private void MudarVez()
    {
        if (vez == 'X')
        {
            vez = 'O';
        }
        else
        {
            vez = 'X';
        }
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
            vencedor = vez;
            DesenharTabela();
            return;
        }

        if (quantidadeP == 9)
        {
            fimDejogo = true;
            vencedor = ' ';
            DesenharTabela();
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
        Console.WriteLine("Digite uma posição de 1 a 9 correspondente à tabela");

        bool entradaValida = false;
        int posicaoSelecionada = 0;

        while (!entradaValida)
        {
            bool conversao = int.TryParse(Console.ReadLine(), out posicaoSelecionada);

            if (conversao && posicaoSelecionada >= 1 && posicaoSelecionada <= 9)
            {
                entradaValida = ValidarEscolha(posicaoSelecionada);
            }

            if (!entradaValida)
            {
                Console.WriteLine("Entrada inválida. Digite um número de 1 a 9 que esteja livre.");
            }
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
        {
            return true;
        }
    }

    private void DesenharTabela()
    {
        Console.Clear();

        Console.WriteLine("Jogo da Velha\n");

        for (int i = 0; i < 9; i += 3)
        {
            Console.WriteLine($" {posicoes[i]} | {posicoes[i + 1]} | {posicoes[i + 2]} ");
            if (i < 6)
            {
                Console.WriteLine("---|---|---");
            }
        }

        Console.WriteLine("\n");

        if (!fimDejogo)
        {
            Console.WriteLine($"Vez de {vez}\n");
        }
    }

    static void Main(string[] args)
    {
        new JogoDaVelha().start();
    }
}
