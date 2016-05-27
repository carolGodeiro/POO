using System;

public class Questao08 {
	public static void Main (string[] args) {
		Console.Write("Forneça o valor da hora de aula: ");
		double vH = double.Parse(Console.ReadLine());
		Console.Write("Forneça a quantidade de aulas dadas em um mês: ");
		int nA = int.Parse(Console.ReadLine());
		Console.Write("Forneça o percentual de desconto do INSS: ");
		double desc = double.Parse(Console.ReadLine()) / 100;

		double sal = vH * nA;
		Console.WriteLine("Salário: " + (sal - sal * desc));
	}
}