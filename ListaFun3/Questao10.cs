using System;

public class Questao10 {
	public static void Main (string[] args) {
		int soma = 0;

		while (true) {
			Console.Write("Digite o valor de N ou 0 para sair: ");
			int n = int.Parse(Console.ReadLine());

			if (n == 0) break;

			soma += n;
		}

		Console.WriteLine("Soma: " + soma);
	}
}