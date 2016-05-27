using System;

public class Questao03 {
	public static void Main (string[] args) {
		Console.Write("Digite o valor de um produto: ");
		double valor = double.Parse(Console.ReadLine());
		Console.WriteLine("Valor com desconto: " + valor * 0.9);
	}
}