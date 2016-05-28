using System;

public class Questao18 {
	public static void Main (string[] args) {
		Console.Write("Dia: ");
		int d = int.Parse(Console.ReadLine());
		Console.Write("Mês: ");
		int m = int.Parse(Console.ReadLine());
		Console.Write("Ano: ");
		int a = int.Parse(Console.ReadLine());

		if ((d >= 1 && d <= 31) && (m >= 1 && m <= 12) && (a > 0)) {
			if (d == 31 && m < 12) {
				d = 1;
				m += 1;
			} else if (d == 31 && m == 12) {
				d = 1;
				m = 1;
				a += 1;
			} else if (d < 31 && m < 12) {
				d += 1;
			} else if (d < 31 && m == 12) {
				d += 1;
			}
			Console.WriteLine(d + "/" + m + "/" + a);
		} else Console.WriteLine("Data inválida");
	}
}