using System;

public class Questao17 {
	public static void Main (string[] args) {
		int soma = 0, num = 0;

		while (true) {
			Console.Write("Digite um número ou 0 para sair: ");
			int n = int.Parse(Console.ReadLine());

			if (n == 0) break;

			soma += n;
			num++;
		}

		Console.WriteLine("Soma: " + soma + "\nQuantidade de números: " + num);
	}
}