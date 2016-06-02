using System;

public class Questao03 {
	public static void Main (string[] args) {
		int soma = 0;

		for (int i = 0; i <= 200; i++) {
			soma += i;
			i++;
		}

		Console.WriteLine(soma);
	}
}