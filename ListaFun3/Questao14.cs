using System;

public class Questao14 {
	public static void Main (string[] args) {
		Console.Write("N1: ");
		int maior = int.Parse(Console.ReadLine());
		int menor = maior;

		for (int i = 2; i <= 30; i++) {
			Console.Write("N" + i + ": ");
			int n = int.Parse(Console.ReadLine());

			if (n > maior) {
				maior = n;
			} else if (n < menor) {
				menor = n;
			}
		}

		Console.WriteLine(maior + " " + menor);
	}
}