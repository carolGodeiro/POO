using System;

public class Questao23 {
	public static void Main (string[] args) {
		Console.Write("N: ");
		int n = int.Parse(Console.ReadLine());
		int c = 0;

		if (n > 0) {
			for (int i = 1; i <= n; i++) {
				if (n % i == 0) c++;
			}

			if (c == 2) Console.WriteLine("Primo");
			else Console.WriteLine("Não é primo");
		}
	}
}