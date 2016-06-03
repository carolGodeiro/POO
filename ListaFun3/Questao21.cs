using System;

public class Questao21 {
	public static void Main (string[] args) {
		Console.Write("N: ");
		int n = int.Parse(Console.ReadLine());

		for (int i = 1; i <= n; i++) {
			if (n % i == 0) Console.WriteLine(i);
		}
	}
}