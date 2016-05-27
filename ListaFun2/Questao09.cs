using System;

public class Questao09 {
	public static void Main (string[] args) {
		Console.Write("Digite o valor do raio: ");
		double raio = double.Parse(Console.ReadLine());

		Console.WriteLine("Perímetro: " + (2 * Math.PI * raio) + "\nÁrea: " + (Math.PI * (raio * raio)));
	}
}