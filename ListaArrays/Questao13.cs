using System;

public class Questao13 {
	public static void Main (string[] args) {
		int[] a = new int[10];
		int maior = 0, indiceA = 0, indiceB = 0;

		for (int i = 0; i < a.Length; i++) {
			Console.Write("Índice " + i + ": ");
			a[i] = int.Parse(Console.ReadLine());
		}

		for (int i = 0; i < a.Length - 1; i++) {
			int diferenca = a[i] - a[i + 1];

			if (diferenca < 0) {
				diferenca *= -1;
			}

			if (diferenca > maior) {
				maior = diferenca;
				indiceA = i;
				indiceB = i + 1;
			}
		}

		Console.WriteLine("A maior diferença é: " + maior + "\nNos índices: " + indiceA + " e " + indiceB);
	}
}