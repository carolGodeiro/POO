using System;

public class NumeroPerfeito {
	public static void Main (string[] args) {
		Console.Write("N: ");
		int n = int.Parse(Console.ReadLine());
		int soma = 0;

		for (int i = 1; i < n; i++) {
			if (n % i == 0) {
				soma += i;
				Console.Write(i + " ");
			}
		}

		if (soma == n) Console.WriteLine("\nO número " + n + " é perfeito");
		else Console.WriteLine("\nO número " + n + " não é perfeito");
	}
}