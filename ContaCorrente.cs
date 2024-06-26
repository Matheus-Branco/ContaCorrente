namespace ContaCorrente
{
    public class ContaCorrente
    {
        public int Numero;
        public double Saldo;
        public bool Especial;
        public double Limite;
        public List<Movimentacao> HistoricoMovimentacoes;
        public string Nome;
        public string Sobrenome;
        public string CPF;

        public ContaCorrente(int numero, double saldoInicial, bool especial, double limite, string nome, string sobrenome, string cpf)
        {
            Numero = numero;
            Saldo = saldoInicial;
            Especial = especial;
            Limite = limite;
            HistoricoMovimentacoes = new List<Movimentacao>();
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            HistoricoMovimentacoes.Add(new Movimentacao(valor, TipoMovimentacao.Credito));
        }

        public bool Sacar(double valor)
        {
            if (Saldo + Limite >= valor)
            {
                Saldo -= valor;
                HistoricoMovimentacoes.Add(new Movimentacao(valor, TipoMovimentacao.Debito));
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
                return false;
            }
        }

        public double VisualizarSaldo()
        {
            return Saldo;
        }

        public void VisualizarExtrato()
        {
            Console.WriteLine($"Extrato da conta {Numero} - Cliente: {Nome} {Sobrenome}");
            foreach (var movimentacao in HistoricoMovimentacoes)
            {
                Console.WriteLine($"{movimentacao.Tipo}: {movimentacao.Valor}");
            }
        }

        public void Transferir(ContaCorrente destino, double valor)
        {
            if (this.Sacar(valor))
            {
                destino.Depositar(valor);
            }
            else
            {
                Console.WriteLine("Transferência não realizada devido a saldo insuficiente.");
            }
        }
    }
