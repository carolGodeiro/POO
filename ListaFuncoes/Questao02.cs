using System;

public class Questao02 {
	public static void Main (string[] args) {
		Console.WriteLine(num(1, 2));
		Console.WriteLine(num(2, 1));
		Console.WriteLine(num(1, 1));
	}

	private static int num (int a, int b) {
		if (a > b) {
			return 1;
		} else if (b > a) {
			return -1;
		}

		return 0;
	}
}