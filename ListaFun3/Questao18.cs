using System;

public class Questao18 {
	public static void Main (string[] args) {
		Console.Write("A: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("N: ");
		int n = int.Parse(Console.ReadLine());

		Console.WriteLine(Math.Pow(a, n));
	}
}