using System;

public class Questao13 {
	public static void Main (string[] args) {
		for (int i = 1; i <= 200; i++) {
			if (i % 3 == 0 || i % 5 == 0) Console.WriteLine(i);
		}
	}
}