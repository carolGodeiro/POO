using System;

public class Questao10 {
	public static void Main (string[] args) {
		int[] a1 = new int[10];
		int[] a2 = new int[10];

		for (int i = 0; i < a1.Length; i++) {
			Console.Write("N: ");
			a1[i] = int.Parse(Console.ReadLine());
			a2[i] = (int) Math.Pow(a1[i], 2);
		}

		for (int i = 0; i < a1.Length; i++) {
			Console.Write(a2[i] + " ");
		}
	}
}