using System;

public class Questao14 {
	public static void Main (string[] args) {
		int[] a = new int[50];
		int qtd = 0;

		for (int i = 0; i < a.Length; i++) {
			Console.Write("N" + (i + 1) + ": ");
			a[i] = int.Parse(Console.ReadLine());
		}

		int[] naoRepete = new int[a.Length];
		for (int i = 0; i < a.Length; i++) {
			bool existe = false;
			for (int j = 0; j < qtd; j++) {
				if (naoRepete[j] == a[i]) {
					existe = true;
					break;
				}
			}
			if (!existe) {
				naoRepete[qtd++] = a[i];
			}
		}

		Console.WriteLine("Existem " + qtd + " elementos não repetidos.\n");
	}
}