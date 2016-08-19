using System;

public class Questao19 {
	public static void Main (string[] args) {
		Console.WriteLine(circunferencia(4));
	}

	private static double circunferencia (double raio) {
		return 2 * Math.PI * raio;
	}
}