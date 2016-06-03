using System;

public class Questao24 {
	public static void Main (string[] args) {
		int primos = 0;
		int cont = 0;

		while (true) {
			Console.Write("N (0 para sair): ");
			int n = int.Parse(Console.ReadLine());

			if (n == 0) break;

			for (int i = 1; i <= n; i++) {
				if (n % i == 0) {
					cont = cont + 1;
				}
			}

			if (cont == 2) primos++;
			cont = 0;
		}

		Console.WriteLine("Primos: " + primos);
	}
}