using System;

public class Questao17 {
	public static void Main (string[] args) {
		int a = 5;
		int b = 10;
		trocar(ref a, ref b);

		Console.WriteLine("A: " + a + "\nB: " + b);
	}

	private static void trocar (ref int a, ref int b) {
		int aux = a;
		a = b;
		b = aux;
	}
}