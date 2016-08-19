using System;

public class Questao13 {
	public static void Main (string[] args) {
		divisores(20);
	}

	private static void divisores (int n) {
		for (int i = 1; i <= 20; i++) {
			if (n % i == 0) Console.WriteLine(i);
		}
	}
}