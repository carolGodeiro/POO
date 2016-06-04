using System;

public class AnoBissexto {
	public static void Main (string[] args) {
		Console.Write("Ano: ");
		int ano = int.Parse(Console.ReadLine());

		if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0)) Console.WriteLine(ano + " é um ano bissexto");
		else Console.WriteLine(ano + " não é um ano bissexto");
	}
}