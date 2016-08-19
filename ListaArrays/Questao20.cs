using System;

public class Questao20 {
	public static void Main (string[] args) {
		int[] mat = new int[3];
		double[] not = new double[3];

		for (int i = 0; i < mat.Length; i++) {
			Console.Write("Matrícula do aluno nº " + (i + 1) + ": ");
			mat[i] = int.Parse(Console.ReadLine());
			Console.Write("Nota do aluno nº " + (i + 1) + ": ");
			not[i] = double.Parse(Console.ReadLine());
			Console.WriteLine("------------");

			for (int x = mat.Length; x >= 1; x--) {
				for (int j = 1; j <= i; j++) {
					if (mat[j - 1] > mat[j]) {
						int aux = mat[j];
						mat[j] = mat[j - 1];
						mat[j - 1] = aux;

						double auxN = not[j];
						not[j] = not[j - 1];
						not[j - 1] = auxN;
					}
				}
			}
		}

		for (int i = 0; i < mat.Length; i++) {
			Console.WriteLine("Matrícula: " + mat[i]);
			Console.WriteLine("Nota: " + not[i]);
			Console.WriteLine("------------");
		}
	}
}