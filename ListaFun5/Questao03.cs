using System;

public class Questao03 {
	public static void Main (string[] args) {
		Console.Write("Digite o primeiro número: ");
		int a = int.Parse(Console.ReadKey());
		Console.Write("Digite o segundo número: ");
		int b = int.Parse(Console.ReadKey());

		if (a == b) Console.WriteLine("Números iguais");
		else Console.WriteLine("Números diferentes");
	}
}