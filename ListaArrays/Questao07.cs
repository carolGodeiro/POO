using System;

public class Questao07 {
	public static void Main (string[] args) {
		int[] numeros = new int[10];
		int maior = 0, menor = 0, iMenor = 0, iMaior = 0;
		Console.Write("N: ");
		maior = menor = int.Parse(Console.ReadLine());

		for (int i = 1; i < numeros.Length; i++) {
			Console.Write("N: ");
			numeros[i] = int.Parse(Console.ReadLine());
			if (numeros[i] > maior) {
				maior = numeros[i];
				iMaior = i;
			}
			if (numeros[i] < menor) {
				menor = numeros[i];
				iMenor = i;
			}
		}

		Console.WriteLine("Maior: " + maior + "\nÍndice: " + iMenor + "\nMenor: " + menor + "\nÍndice: " + iMenor);
	}
}