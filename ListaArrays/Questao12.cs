using System;

public class Questao12 {
	public static void Main (string[] args) {
		int[] a = new int[10];
		int[] b = new int[10];
		int[] c = new int[10];

		for (int i = 0; i < a.Length; i++) {
			Console.Write("A" + (i + 1) + ": ");
			a[i] = int.Parse(Console.ReadLine());
			Console.Write("B" + (i + 1) + ": ");
			b[i] = int.Parse(Console.ReadLine());
			c[i] = a[i] * b[i];
		}

		for (int i = 0; i < c.Length; i++) {
			Console.Write(c[i] + " ");
		}
	}
}