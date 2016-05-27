using System;

public class Questao12 {
	public static void Main (string[] args) {
		Console.Write("Custo total: ");
		double total = double.Parse(Console.ReadLine());
		Console.Write("Preço do convite: ");
		double preco = double.Parse(Console.ReadLine());

		Console.WriteLine("Devem ser vendidos " + ((int) total / preco) + " convites");
	}
}