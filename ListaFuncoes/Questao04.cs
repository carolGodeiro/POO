using System;

public class Questao04 {
	public static void Main (string[] args) {
		Console.WriteLine(potencia(2, 3));
	}

	private static double potencia(int b, int e) {
		return Math.Pow(b, e);
	}
}