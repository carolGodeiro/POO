using System;

public class Questao17 {
	public static void Main (string[] args) {
		int[] a = new int[30];
		string aux = "";
		string maior = "";

		for (int i = 0; i < a.Length; i++) {
			Console.Write("N" + (i + 1) + ": ");
			a[i] = int.Parse(Console.ReadLine());
		}

		for (int i = 1; i < a.Length; i++) {
			if (a[i] > a[i - 1]) {
				aux += "a";
				if (aux.Length > maior.Length) {
					maior = aux;
				}
			} else {
				aux = "";
			}
		}

		Console.WriteLine("A maior sublista ordenada crescente tem tamanho " + (maior.Length + 1));
	}
}