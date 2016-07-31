using System;

public class Questao06 {
	public static void Main (string[] args) {
		int[] numeros = new int[10];
		int maior = 0, indice = 0;
		Console.Write("N: ");
		maior = int.Parse(Console.ReadLine());

		for (int i = 1; i < numeros.Length; i++) {
			Console.Write("N: ");
			numeros[i] = int.Parse(Console.ReadLine());
			if (numeros[i] > maior) {
				maior = numeros[i];
				indice = i;
			}
		}

		Console.WriteLine("Maior: " + maior + "\nÍndice: " + indice);
	}
}