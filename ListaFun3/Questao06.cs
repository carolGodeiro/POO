using System;

public class Questao06 {
	public static void Main (string[] args) {
		Console.Write("Primeiro número: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Segundo número: ");
		int m = int.Parse(Console.ReadLine());

		while (n <= m) {
			Console.WriteLine(n);
			n++;
		}

		Console.ReadKey();
	}
}