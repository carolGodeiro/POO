using System;

public class Questao11 {
	public static void Main (string[] args) {
		Console.WriteLine(espacos("They see me rollin"));
	}

	private static int espacos (string s) {
		int qtd = 0;
		for (int i = 0; i < s.Length; i++) {
			if (s[i] == ' ') qtd++;
		}

		return qtd;
	}
}