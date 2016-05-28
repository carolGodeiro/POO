using System;

public class Questao04 {
	public static void Main (string[] args) {
		Console.WriteLine("Digite o primeiro número: ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o segundo número: ");
		int b = int.Parse(Console.ReadLine());

		if (a > b) Console.WriteLine("A é o maior");
		else Console.WriteLine("B é o maior");
	}
}