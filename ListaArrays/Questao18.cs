using System;

public class Questao18 {
	public static void Main (string[] args) {
		int[] a = new int[10];

		for (int i = 0; i < a.Length; i++) {
			Console.Write("N" + (i + 1) + ": ");
			a[i] = int.Parse(Console.ReadLine());

			for (int x = a.Length; x >= 1; x--) {
				for (int j = 1; j <= i; j++) {
					if (a[j - 1] > a[j]) {
						int aux = a[j];
						a[j] = a[j - 1];
						a[j - 1] = aux;
					}
				}
			}
		}

		Console.Write("Matriz ordenada: ");
		for (int i = 0; i < a.Length; i++) {
			Console.Write(a[i] + " ");
		}
	}
}