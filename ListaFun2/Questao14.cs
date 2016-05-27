using System;

public class Questao14 {
	public static void Main (string[] args) {
		Console.Write("Digite o valor do primeiro ângulo: ");
		int ang1 = int.Parse(Console.ReadLine());

		Console.Write("Digite o valor do segundo ângulo: ");
		int ang2 = int.Parse(Console.ReadLine());

		Console.WriteLine("O valor do terceiro ângulo é: " + (180 - (ang1 + ang2)));
	}
}