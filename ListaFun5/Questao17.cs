using System;

public class Questao17 {
	public static void Main (string[] args) {
		Console.Write("D: ");
		int d = int.Parse(Console.ReadLine());
		Console.Write("M: ");
		int m = int.Parse(Console.ReadLine());
		Console.Write("A: ");
		int a = int.Parse(Console.ReadLine());

		if ((d >= 1 && d <= 31) && (m >= 1 && m <= 12) && (a > 0)) Console.WriteLine("Data válida");
		else Console.WriteLine("Data inválida");
	}
}