using System;

public class Questao20 {
	public static void Main (string[] args) {
		Console.WriteLine(area(4));
	}

	private static double area (double raio) {
		return Math.PI * Math.Pow(raio, 2);
	}
}