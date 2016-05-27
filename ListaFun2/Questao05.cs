using System;

public class Questao05 {
	public static void Main (string[] args) {
		Console.Write("Digite um número entre 0 e 60: ");
		int numero = int.Parse(Console.ReadLine());

		int sucessor = (numero + 1) % 61;
		Console.WriteLine("Sucessor: " + sucessor);
	}
}