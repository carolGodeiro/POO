using System;

public class Questao01 {
	public static void Main (string[] args) {
		Console.Write("Digite um número inteiro: ");
		int n = int.Parse(Console.ReadLine());

		if (n > 0) Console.WriteLine("Positivo");
		else if (n < 0) Console.WriteLine("Negativo");
		else Console.WriteLine("Nulo, n = 0");
	}
}