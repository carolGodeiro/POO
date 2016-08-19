using System;

public class Questao05 {
	public static void Main (string[] args) {
		Data1 d1 = new Data1();
		Data2 d2 = new Data2();

		Console.WriteLine("-- Data 1 --");
		Console.Write("Dia > ");
		d1.dia = int.Parse(Console.ReadLine());
		Console.Write("Mês > ");
		d1.mes = int.Parse(Console.ReadLine());
		Console.Write("Ano > ");
		d1.ano = int.Parse(Console.ReadLine());

		Console.WriteLine("-- Data 2 --");
		Console.Write("Dia > ");
		d2.dia = int.Parse(Console.ReadLine());
		Console.Write("Mês > ");
		d2.mes = int.Parse(Console.ReadLine());
		Console.Write("Ano > ");
		d2.ano = int.Parse(Console.ReadLine());

		int diferencaDias, diferencaMeses, diferencaAnos;
		diferencaDias = d1.dia - d2.dia;
		diferencaMeses = d1.mes - d2.mes;
		diferencaAnos = d1.ano - d2.ano;

		if (diferencaDias < 0) {
			diferencaDias *= -1;
		}

		if (diferencaMeses < 0) {
			diferencaMeses *= -1;
		}

		if (diferencaAnos < 0) {
			diferencaAnos *= -1;
		}

		diferencaMeses *= 30;
		diferencaAnos *= 360;

		Console.WriteLine("Aproximadamente: " + (diferencaDias + diferencaMeses + diferencaAnos) + " dias");
	}

	struct Data1 {
		public int dia;
		public int mes;
		public int ano;
	}

	struct Data2 {
		public int dia;
		public int mes;
		public int ano;
	}
}