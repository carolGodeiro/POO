using System;

public class Questao07 {
	public static void Main (string[] args) {
		Console.Write("Digite a temperatura em graus centígrados: ");
		double c = double.Parse(Console.ReadLine());

		Console.WriteLine("Temperatura em ºF: " + (9 * c + 160) / 5);
	}
}