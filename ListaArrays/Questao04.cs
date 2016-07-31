using System;

public class Questao04 {
	public static void Main (string[] args) {
		int[] numeros = new int[20];
		int pares = 0, impares = 0;

		for (int i = 0; i < numeros.Length; i++) {
			Console.Write("N: ");
			int n = int.Parse(Console.ReadLine());
			numeros[i] = n;
		}

		for (int i = 0; i < numeros.Length; i++) {
			if (numeros[i] % 2 == 0) {
				Console.WriteLine(numeros[i] + "\t--> PAR");
				pares++;
			} else {
				Console.WriteLine(numeros[i] + "\t--> ÍMPAR");
				impares++;
			}
		}

		Console.WriteLine("TOTAL:\n\t" + pares + " números pares\n\t" + impares + " números ímpares");
	}
}