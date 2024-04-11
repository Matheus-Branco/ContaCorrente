using System;

public class ContaCorrente
{
    public cliente titular;
    public movimentacao[] historico;
    public decimal saldo;

    Console.WriteLine("Bem vindo");

            string operacao = "";

            //1 para ver seu saldo, 2 para saquar, 3 para depositar
            if (operacao == "1")
            {
                Console.Write(Cliente.saldo);
            }
            if (operacao == "2")
            {
                Sacar();
            }
            if (operacao == "3")
            {
                Depositar();
            }
    
}
