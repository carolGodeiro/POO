using System;

public class Questao08 {
	public static void Main (string[] args) {
		Console.Write("A: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("B: ");
		int b = int.Parse(Console.ReadLine());
		int aux = 0;

		if (a > b) {
			aux = a;
			a = b;
			b = aux;
		}

		Console.WriteLine("Ordem crescente: " + a + " " + b);
	}
}