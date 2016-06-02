using System;

public class Questao15 {
	public static void Main (string[] args) {
		int pares = 0, impares = 0;

		while (true) {
			Console.WriteLine("Digite um número inteiro ou -1 para sair: ");
			int n = int.Parse(Console.ReadLine());

			if (n == -1) break;

			if (n % 2 == 0) pares++;
			else impares++;
		}

		Console.WriteLine("Pares: " + pares + "\nÍmpares: " + impares);
	}
}