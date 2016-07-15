using System;

public class Questao02 {
	public static void Main (string[] args) {
		int[] numeros = new int[10];

		for (int i = 0; i < numeros.Length; i++) {
			Console.Write("N: ");
			numeros[i] = int.Parse(Console.ReadLine());
		}

		for (int i = numeros.Length - 1; i >= 0; i--) {
			Console.Write(numeros[i] + " ");
		}
	}
}