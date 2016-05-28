using System;

public class Questao07 {
	public static void Main (string[] args) {
		Console.Write("N1: ");
		double n1 = double.Parse(Console.ReadLine());
		Console.Write("N2: ");
		double n2 = double.Parse(Console.ReadLine());

		if ((n1 + n2 / 2) >= 6) Console.WriteLine("Aprovado");
		else Console.WriteLine("Reprovado");
	}
}