using System;

public class Questao11 {
	public static void Main (string[] args) {
		int[] a1 = new int[8];
		int[] a2 = new int[8];
		int aux;

		Console.WriteLine("A1");
		for (int i = 0; i < a1.Length; i++) {
			a1[i] = int.Parse(Console.ReadLine());
		}

		Console.WriteLine("\nA2");
		for (int i = 0; i < a2.Length; i++) {
			a2[i] = int.Parse(Console.ReadLine());
			aux = a1[i];
			a1[i] = a2[i];
			a2[i] = aux;
		}

		Console.WriteLine("\nA1\tA2");
		for (int i = 0; i < a1.Length; i++) {
			Console.WriteLine(a1[i] + "\t" + a2[i]);
		}
	}
}