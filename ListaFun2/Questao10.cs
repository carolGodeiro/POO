using System;

public class Questao10 {
	public static void Main (string[] args) {
		Console.Write("Digite a altura do degrau: ");
		double h = double.Parse(Console.ReadLine());
		Console.Write("Qual altura você deseja atingir? ");
		double hA = double.Parse(Console.ReadLine());

		Console.WriteLine("Você deverá subir " + hA / h + " degraus.");
	}
}