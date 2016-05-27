using System;

public class Questao11 {
	public static void Main (string[] args) {
		Console.Write("Peso do saco de ração (KG): ");
		double p = double.Parse(Console.ReadLine()) * 1000;
		Console.Write("Quantidade para o primeiro gato (g): ");
		double c1 = double.Parse(Console.ReadLine());
		Console.Write("Quantidade para o segundo gato (g): ");
		double c2 = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Após 5 dias: " + (p - ((c1 + c2) * 5)));
	}
}