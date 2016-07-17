using System;

public class Questao08 {
	public static void Main (string[] args) {
		int[] numeros = new int[10];
		int maior = 0, indice = 0, aux = 0;

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
		aux = numeros[9];
		numeros[9] = maior;
		Console.WriteLine("Maior: " + maior + "\nÍndice do maior: " + indice + "\nValor do último índice: " + aux);
	}
}