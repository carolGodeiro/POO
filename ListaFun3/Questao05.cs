using System;

public class Questao05 {
	public static void Main (string[] args) {
		Console.Write("Número: ");
		int n = int.Parse(Console.ReadLine());
		int soma = 0;

		for (int i = 0; i <= n; i++) {
			soma += i;
			i++;
		}

		Console.WriteLine("Soma: " + soma);
		Console.ReadKey();
	}
}