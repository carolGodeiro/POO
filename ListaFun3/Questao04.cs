using System;

public class Questao04 {
	public static void Main (string[] args) {
		for (int i = 0; i <= 40; i++) {
			if (i % 2 == 0) {
				Console.WriteLine(i);
			}
		}
		Console.ReadKey();
	}
}