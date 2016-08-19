using System;

public class Questao16 {
	public static void Main (string[] args) {
		int[] a1 = new int[30];
		int[] a2 = new int[30];
		int[] a3 = new int[60];

		for (int i = 0; i < a1.Length; i++) {
			Console.Write("Índice " + i + " do vetor 1: ");
			a1[i] = int.Parse(Console.ReadLine());
			a3[i] = a1[i];
		}

		Console.WriteLine("-----------");

		for (int i = 0; i < a2.Length; i++) {
			Console.Write("Índice " + i + " do vetor 2: ");
			a2[i] = int.Parse(Console.ReadLine());
			a3[i + 3] = a2[i];
		}

		Console.Write("A3: ");
		Array.Sort(a3);
		for (int i = 0; i < a3.Length; i++) {
			Console.Write(a3[i] + " ");
		}
	}
}