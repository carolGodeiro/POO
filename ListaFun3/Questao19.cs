using System;

public class Questao19 {
	public static void Main (string[] args) {
		Console.Write("N: ");
		int n = int.Parse(Console.ReadLine());
		int fat = 1;

		for (int i = 1; i <= n; i++) {
			fat *= i;
		}

		Console.WriteLine(fat);
	}
}