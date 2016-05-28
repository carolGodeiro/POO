using System;

public class Questao11 {
	public static void Main (string[] args) {
		Console.Write("N1: ");
		int n = int.Parse(Console.ReadLine());

		int maior = n;
		int menor = n;

		for (int i = 2; i <= 5; i++) {
			Console.Write("N" + i + ": ");
			n = int.Parse(Console.ReadLine());

			if (n < menor) menor = n;
			if (n > maior) maior = n;
		}

		Console.WriteLine("Maior: " + maior + "\nMenor: " + menor);
	}
}