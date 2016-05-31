using System;

public class Questao11 {
	public static void Main (string[] args) {
		Console.Write("Digite um valor para N: ");
		int n = int.Parse(Console.ReadLine());

		for (int i = 1; i <= 10; i++) {
			Console.WriteLine(n + " x " + i + " = " + (n * i));
		}
	}
}