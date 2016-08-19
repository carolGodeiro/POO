using System;

public class Questao14 {
	public static void Main (string[] args) {
		divisores(20);
	}

	private static int[] divisores (int n) {
		int[] divs = new int[n + 1];
		for (int i = 1; i <= 20; i++) {
			if (n % i == 0) divs[i] = i;
		}

		for (int i = 0; i < divs.Length; i++) {
			if (divs[i] != 0) Console.Write(divs[i] + " ");
		}

		return divs;
	}
}