using System;

public class Questao18 {
	public static void Main (string[] args) {
		Console.Write("N: ");
		int n = int.Parse(Console.ReadLine());
		double soma = 0;

		for (int i = 1; i <= n; i++) {
			if (i % 2 == 0) soma -= 1 / i;
			else soma += 1 / i;
		}

		Console.WriteLine("Soma: " + soma);
	}
}