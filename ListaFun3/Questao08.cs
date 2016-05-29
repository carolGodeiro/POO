using System;

public class Questao08 {
	public static void Main (string[] args) {
		Console.Write("N: ");
		double n = int.Parse(Console.ReadLine());
		double soma = 0;
		int i = 1;
		
		while (n >= i) {
			soma += 1 / n;
			n--;
		}

		Console.WriteLine("Soma: " + soma);
		Console.ReadKey();
	}
}