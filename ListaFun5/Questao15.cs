using System;

public class Questao15 {
	public static void Main (string[] args) {
		Console.Write("Ângulo: ");
		double a = double.Parse(Console.ReadLine());

		if (a > 0 && a < 90) Console.WriteLine("Primeiro quadrante");
		else if (a > 90 && a < 180) Console.WriteLine("Segundo quadrante");
		else if (a > 180 && a < 270) Console.WriteLine("Terceiro quadrante");
		else if (a > 270 && a < 360) Console.WriteLine("Quarto quadrante");
	}
}