using System;

public class Questao19 {
	public static void Main (string[] args) {
		string maior = "", data1 = "", data2 = "";
		Console.Write("Dia: ");
		int d1 = int.Parse(Console.ReadLine());
		Console.Write("Mês: ");
		int m1 = int.Parse(Console.ReadLine());
		Console.Write("Ano: ");
		int a1 = int.Parse(Console.ReadLine());
		data1 = d1 + "/" + m1 + "/" + a1;

		Console.WriteLine("--------");

		Console.Write("Dia: ");
		int d2 = int.Parse(Console.ReadLine());
		Console.Write("Mês: ");
		int m2 = int.Parse(Console.ReadLine());
		Console.Write("Ano: ");
		int a2 = int.Parse(Console.ReadLine());
		data2 = d2 + "/" + m2 + "/" + a2;

		if ((d1 >= 1 && d1 <= 31) && (m1 >= 1 && m1 <= 12) && (a1 > 0) && (d2 >= 1 && d2 <= 31) && (m2 >= 1 && m2 <= 12) && (a2 > 0)) {
			if (a1 > a2) maior = data1;
			else if (a1 < a2) maior = data2;
			else {
				if (m1 > m2) maior = data1;
				else if (m1 < m2) maior = data2;
				else {
					if (d1 > d2) maior = data1;
					else if (d1 < d2) maior = data2;
					else maior = "Datas iguais";
				}
			}
		} else Console.WriteLine("Data(s) inválida(s)");

		Console.WriteLine(maior);
	}
}