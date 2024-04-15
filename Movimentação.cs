public class Movimentacao
    {
        public double Valor;
        public TipoMovimentacao Tipo; 

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
