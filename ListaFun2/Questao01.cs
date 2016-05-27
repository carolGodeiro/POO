using System;

public class Questao01 {
	public static void Main (string[] args) {
		Console.Write("Digite o valor do lado: ");
		int lado = int.Parse(Console.ReadLine());

		Console.WriteLine("Perímetro: " + lado * 4);
		Console.WriteLine("Área: " + lado * lado);
	}
}