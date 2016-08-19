using System;

public class Questao15 {
	public static void Main (string[] args) {
		int[] a1 = new int[30];
		int[] a2 = new int[30];
		int[] a3 = new int[30];
		int k = 0;

		for (int i = 0; i < a1.Length; i++) {
			Console.Write("Índice " + i + " do vetor 1: ");
			a1[i] = int.Parse(Console.ReadLine());
		}

		Console.WriteLine("-----------");

		for (int i = 0; i < a1.Length; i++) {
			Console.Write("Índice " + i + " do vetor 2: ");
			a2[i] = int.Parse(Console.ReadLine());
		}

		for (int i = 0; i < a1.Length; i++) {
			for (int j = 0; j < a1.Length; j++) {
				if (a1[j] == a2[i]) {
					a3[k] = a1[i];
					k++;
				}
			}
		}

		Console.WriteLine("Interseção:");
		for (int i = 0; i < k; i++) {
			Console.WriteLine("> " + a3[i]);
		}
	}
}