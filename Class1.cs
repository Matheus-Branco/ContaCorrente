using System;

	/*
	Uma conta corrente possui um número, um saldo, um status que informa se ela é especial ou não, um limite e um conjunto de movimentações.
    Cada conta terá operações de saques, depósitos, visualização de saldo, visualização de extrato e transferência entre contas.
	Cada conta vai ter o nome, o sobrenome e cpf do cliente dono da conta. Uma conta corrente só pode fazer saques desde que o valor não exceda o limite de saque que é o limite + saldo.
	 */
public class Conta
{
	public ContaCorrente()
	{
	public string nomeCompleto;
	public int numero;
	public decimal saldo;
	public string conta;
	public string status;
	public decimal limite;
	public int historico;
	}
}
