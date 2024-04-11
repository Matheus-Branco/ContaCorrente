using System;

public class Movimentacao
{
	public Movimentacao()
	{
        public void ViewSaldo() 
        {
            Cliente Matheus = new Cliente("Matheus ", "Jeremias", 012, 10000, false, 1000000, "012.257.839.25");

            Console.WriteLine(Matheus.saldo);

        }
        public void Sacar()
        {
            Cliente Matheus = new Cliente("Matheus ", "Jeremias", 012, 10000, false, 1000000, "012.257.839.25");
            Cliente Fulano = new Cliente("Fulano", "De tal", 012, 10000, false, 1000000, "012.257.839.25");

            decimal QuantSaquar = 0;
            Console.WriteLine($"Seu saldo é {Sacar.saldo}. Quando você deseja saquar?");

            QuantSaquar = 100;

            if (QuantSaquar > limite + saldo)
            {
                Console.WriteLine($"Você não pode saquar");
            }
            else
            {
                saldo = QuantSaquar - saldo;
                Console.WriteLine($"Seu saldo atual é {saldo}");
            }
        }
        public void Depositar()
        {
            Cliente Depositar = new Cliente("Matheus Jeremias", 012, 10000, false, 1000000, "012.257.839.25");

            decimal QuantDepo = 0;
            Console.WriteLine($"Seu saldo é {Sacar.saldo}. Quando você deseja saquar?");

            QuantDepo = 100;
            
                saldo = QuantDepo + saldo;
                Console.WriteLine($"Seu saldo atual é {saldo}");
        }
        public void Transferir()
        {
            Cliente Matheus = new Cliente("Matheus ", "Jeremias", 012, 10000, false, 1000000, "012.257.839.25");
            Cliente Fulano = new Cliente("Fulano", "De tal", 012, 10000, false, 1000000, "012.257.839.25");

            Matheus.saldo = Fulano.saldo + Matheus.saldo;
        }
    }
}
