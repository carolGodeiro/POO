using System;

public class Questao03 {
	public static void Main (string[] args) {
		Console.WriteLine(parImpar(2));
		Console.WriteLine(parImpar(3));
	}

	private static int parImpar(int n) {
		if (n % 2 == 0) {
			return 1;
		}

		return -1;
	}
}