using System;

public class Questao13 {
	public static void Main (string[] args) {
		Console.Write("Digite o salário: ");
		double salario = double.Parse(Console.ReadLine());

		Console.Write("Digite o total a ser pago na primeira conta: ");
		double totalPrimeira = double.Parse(Console.ReadLine());

		Console.Write("Digite o total a ser pago na segunda conta: ");
		double totalSegunda = double.Parse(Console.ReadLine());

		Console.Write("Digite o total de dias atrasados: ");
		int dias = int.Parse(Console.ReadLine());

		double juros = totalPrimeira + totalSegunda + (totalPrimeira * 0.2 * (dias * 0.1)) + (totalSegunda * 0.2 * (dias * 0.1));
		Console.WriteLine("João ficará com: " + (salario - juros) + " reais");
	}
}