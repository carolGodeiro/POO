using System;

public class Questao10 {
	public static void Main (string[] args) {
		Console.Write("N: ");
		int n = int.Parse(Console.ReadLine());

		if (n > 0) Console.WriteLine(Math.Sqrt(n));
		else if (n < 0) Console.WriteLine(Math.Pow(n, 2));
	}
}