using System;

public class Questao09 {
	public static void Main (string[] args) {
		int[] numeros = new int[20];

		for (int i = numeros.Length - 1; i >= 0; i--) {
			Console.Write("N: ");
			numeros[i] = int.Parse(Console.ReadLine());
		}

		for (int i = 0; i < numeros.Length; i++) {
			Console.Write(numeros[i] + " ");
		}
	}
}