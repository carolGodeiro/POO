using System;

public class Questao15 {
	public static void Main (string[] args) {
		Console.Write("Entre com o valor do primeiro cateto: ");
		double cat1 = double.Parse(Console.ReadLine());

		Console.Write("Entre com o valor do segundo cateto: ");
		double cat2 = double.Parse(Console.ReadLine());
		
		Console.WriteLine("O valor da hipotenusa é: " + Math.Sqrt((cat1 * cat1) + (cat2 * cat2)));
	}
}