using System;

public class Questao19 {
	public static void Main (string[] args) {
		int[] a = new int[50];

		for (int i = 0; i < a.Length; i++) {
			Console.Write("N" + (i + 1) + ": ");
			a[i] = int.Parse(Console.ReadLine());
		}

		Array.Sort(a);
		Console.Write("Matriz ordenada: ");
		for (int i = 0; i < a.Length; i++) {
			Console.Write(a[i] + " ");
		}
	}
}