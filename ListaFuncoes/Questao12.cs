using System;

public class Questao12 {
	public static void Main (string[] args) {
		Console.WriteLine(primo(4));
		Console.WriteLine(primo(7));
	}

	private static bool primo (int n) {
		int divisores = 0;
		for (int i = 1; i <= n; i++) {
			if (n % i == 0) divisores++;
		}

		if (divisores <= 2) return true;

		return false;
	}
}