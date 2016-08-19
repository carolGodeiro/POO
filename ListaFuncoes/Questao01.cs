using System;

public class Questao01 {
	public static void Main (string[] args) {
		Console.WriteLine(num(-5));
		Console.WriteLine(num(5));
		Console.WriteLine(num(0));
	}

	private static int num (int n) {
		if (n > 0) {
			return 1;
		} else if (n < 0) {
			return -1;
		}

		return 0;
	}
}