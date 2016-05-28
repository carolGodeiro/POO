using System;

public class Questao14 {
	public static void Main (string[] args) {
		Console.Write("A: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("B: ");
		int b = int.Parse(Console.ReadLine());
		Console.Write("C: ");
		int c = int.Parse(Console.ReadLine());

		if (a == b && b == c) Console.WriteLine("Triângulo equilátero");
		else if (a != b && a != c) Console.WriteLine("Triângulo escaleno");
		else Console.WriteLine("Triângulo isósceles");
	}
}