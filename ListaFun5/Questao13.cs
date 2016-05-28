using System;

public class Questao13 {
	public static void Main (string[] args) {
		Console.Write("A: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("B: ");
		int b = int.Parse(Console.ReadLine());
		Console.Write("C: ");
		int c = int.Parse(Console.ReadLine());

		if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Forma um triângulo");
		else Console.WriteLine("Não forma um triângulo");
	}
}