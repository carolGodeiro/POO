using System;

public class Questao07 {
	public static void Main (string[] args) {
		Console.WriteLine(fatorial(10));
	}

	private static int fatorial (int n) {
		int fat = 1;
		for (int i = n; i > 0; i--) {
			fat *= i;
		}

		return fat;
	}
}