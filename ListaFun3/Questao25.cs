using System;

public class Questao25 {
	public static void Main (string[] args) {
		Console.Write("Massa (em gramas): ");
		double m = double.Parse(Console.ReadLine());
		int t = 0;
		double aux = m;

		while (m > 0.5) {
			t += 50;
			m /= 2;
		}

		double segundos = t % 60;
		t /= 60;
		double minutos = t % 60;
		t /= 60;
		double horas = t % 24;

		Console.WriteLine("Massa inicial: " + aux
			+ "\nMassa final: " + m + "\nTempo: "
			+ horas + ":" + minutos + ":" + segundos);
	}
}