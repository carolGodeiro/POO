using System;

public class Questao16 {
	public static void Main (string[] args) {
		Console.WriteLine(data(31, 12, 2012));
	}

	private static string data (int dia, int mes, int ano) {
		bool valido = true, bissexto = false;
		int i = 0;

		while (valido && i == 0) {
			if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0)) bissexto = true;

			if (mes < 1 || mes > 12) valido = false;

			if (dia > 31 || ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 30)) valido = false;

			if ((mes == 2 && bissexto == false && dia > 28) || (mes == 2 && bissexto == true && dia > 29)) valido = false;
			i++;
		}

		if (valido) {
			string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
			return dia + " de " + meses[mes - 1] + " de " + ano;
		}

		return "Data inválida";
	}
}