using System;

public class Questao04 {
	public static void Main (string[] args) {
		Console.Write("Digite o valor da prestação: ");
		double pres = double.Parse(Console.ReadLine());
		Console.Write("Digite o valor da taxa: ");
		double taxa = double.Parse(Console.ReadLine());
		Console.Write("Digite os dias de atraso: ");
		int dias = int.Parse(Console.ReadLine());

		Console.WriteLine("Valor: " + (pres + (pres * (taxa / 100) * dias)));
	}
}