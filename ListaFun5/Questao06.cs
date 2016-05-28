using System;

public class Questao06 {
	public static void Main (string[] args) {
		Console.Write("Digite a nota do aluno: ");
		double nota = double.Parse(Console.ReadLine());

		if (nota >= 0 && nota <= 10) Console.WriteLine("Nota válida");
		else Console.WriteLine("Nota inválida");
	}
}