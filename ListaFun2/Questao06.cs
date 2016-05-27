using System;

public class Questao06 {
	public static void Main (string[] args) {
		Console.Write("Digite o valor do raio: ");
		double raio = double.Parse(Console.ReadLine());
		Console.Write("Digite o valor da altura: ");
		double altura = double.Parse(Console.ReadLine());

		Console.WriteLine("Volume: " + (3.14159 * (raio * raio) * altura));
	}
}