public class Movimentacao
    {
        public double Valor { get; private set; }
        public TipoMovimentacao Tipo { get; private set; }

        public Movimentacao(double valor, TipoMovimentacao tipo)
        {
            Valor = valor;
            Tipo = tipo;
        }
    }

    public enum TipoMovimentacao
    {
        Credito,
        Debito
    }
