using System;

public class Questao12 {
	public static void Main (string[] args) {
		Console.Write("A: ");
		double a = double.Parse(Console.ReadLine());
		Console.Write("B: ");
		double b = double.Parse(Console.ReadLine());
		Console.Write("C: ");
		double c = double.Parse(Console.ReadLine());

		double delta = b * b - 4 * a * c;
		double x1, x2;
		if (delta > 0) {
			Console.WriteLine("Duas raízes reais");
			x1 = (-b + Math.Sqrt(delta)) / (2 * a);
			x2 = (-b - Math.Sqrt(delta)) / (2 * a);

			Console.WriteLine("X1 = " + x1 + "\nX2 = " + x2);
		} else if (delta == 0) {
			Console.WriteLine("Duas raízes reais e iguais");
			x1 = -b / (a * 2);

			Console.WriteLine("X1 = X2 = " + x1);
		} else {
			Console.WriteLine("Não existem raízes reais");
		}
	}
}