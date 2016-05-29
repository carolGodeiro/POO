using System;

public class Questao07 {
	public static void Main (string[] args) {
		int a = 1;
		int b = 1;
		double soma = 0;

		for (int i = 0; i < 100; i++) {
			soma += a / b;
			a += 2;
			b += 1;
			i++;
		}

		Console.WriteLine("Soma: " + soma);
		Console.ReadKey();
	}
}