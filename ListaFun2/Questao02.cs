using System;

public class Questao02 {
	public static void Main (string[] args) {
		Console.Write("Digite o valor da base: ");
		int b = int.Parse(Console.ReadLine());
		Console.Write("Digite o valor da altura: ");
		int a = int.Parse(Console.ReadLine());

		Console.WriteLine("Área: " + (b * a) / 2);
	}
}