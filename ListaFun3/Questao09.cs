using System;

public class Questao09 {
	public static void Main (string[] args) {
		int soma = 0;

		for (int i = 1; i <= 10; i++) {
			Console.Write("Digite o " + i + "º número: ");
			int n = int.Parse(Console.ReadLine());
			soma += n;
		}

		Console.WriteLine("Soma: " + soma);
	}
}