using System;

public class Questao08 {
	public static void Main (string[] args) {
		Console.WriteLine(vogais("They see me rollin"));
	}

	private static int vogais (string s) {
		int qtd = 0;
		for (int i = 0; i < s.Length; i++) {
			if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u') qtd++;
		}

		return qtd;
	}
}