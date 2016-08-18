using System;

public class Questao05 {
	public static void Main (string[] args) {
		Console.WriteLine(raizC(125));
	}

	private static double raizC (int n) {
		return Math.Round(Math.Pow(n, 0.333333333));
	}
}