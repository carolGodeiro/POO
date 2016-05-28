using System;

public class Questao09 {
	public static void Main (string[] args) {
		Console.Write("N: ");
		int n = int.Parse(Console.ReadLine());

		if (n % 2 == 0) Console.WriteLine("O número é par");
		else Console.WriteLine("O número é ímpar");
	}
}