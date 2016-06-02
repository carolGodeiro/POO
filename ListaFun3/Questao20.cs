using System;

public class Questao20 {
	public static void Main (string[] args) {
		int aprovados = 0, reprovados = 0;

		while (true) {
			Console.Write("N1 > ");
			int n1 = int.Parse(Console.ReadLine());
			Console.Write("N2 > ");
			int n2 = int.Parse(Console.ReadLine());
			Console.WriteLine("---------");

			if (n1 == -1 || n2 == -1) break;

			if ((n1 + n2) / 2 >= 6) aprovados++;
			else reprovados++;
		}

		Console.WriteLine("Aprovados: " + aprovados + "\nReprovados: " + reprovados);
	}
}