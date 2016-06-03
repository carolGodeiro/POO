using System;

public class Questao22 {
	public static void Main (string[] args) {
		Console.Write("A: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("B: ");
		int b = int.Parse(Console.ReadLine());

		int aux = 0, resto = 0;
		if (a > b) {
			aux = a;
			a = b;
			b = aux;
		}

		resto = b % a;
		while (b % a != 0) {
			resto = b % a;
			b = a;
			a = resto;
		}

		Console.WriteLine("MDC: " + a);
	}
}