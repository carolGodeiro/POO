using System;

public class Questao05 {
	public static void Main (string[] args) {
		int[] notas = new int[3];
		int media = 0, acimaMedia = 0;

		for (int i = 0; i < notas.Length; i++) {
			Console.Write("Nota > ");
			int n = int.Parse(Console.ReadLine());
			notas[i] = n;
		}

		for (int i = 0; i < notas.Length; i++) {
			media += notas[i];
			if (notas[i] >= 60) {
				Console.Write(notas[i] + " ");
				acimaMedia++;
			}
		}

		Console.WriteLine("\nMédia: " + media / 30 + "\nAlunos acima da da média: " + acimaMedia);
	}
}