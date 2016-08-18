using System;

public class Questao09 {
	public static void Main (string[] args) {
		Console.WriteLine(consoantes("They see me rollin"));
	}

	private static int consoantes (string s) {
		int qtd = 0;
		for (int i = 0; i < s.Length; i++) {
			if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u' && s[i] != ' ') qtd++;
		}

		return qtd;
	}
}