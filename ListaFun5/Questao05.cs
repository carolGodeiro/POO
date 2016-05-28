using System;

public class Questao05 {
	public static void Main (string[] args) {
		Console.Write("Digite o primeiro número: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Digite o segundo número: ");
		int b = int.Parse(Console.ReadLine());
		Console.Write("Digite o terceiro número: ");
		int c = int.Parse(Console.ReadLine());

		if (a > b && a > c) Console.WriteLine("A é o maior");
		else if (b > a && b > c) Console.WriteLine("B é o maior");
		else Console.WriteLine("C é o maior");
	}
}