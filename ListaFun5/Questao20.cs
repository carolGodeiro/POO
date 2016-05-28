using System;

public class Questao20 {
	public static void Main (string[] args) {
		Console.Write("A: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("B: ");
		int b = int.Parse(Console.ReadLine());
		Console.Write("C: ");
		int c = int.Parse(Console.ReadLine());

		if (a > b && a > c && b > c) Console.WriteLine(a + " " + b + " " + c);
		else if (a > b && a > c && c > b) Console.WriteLine(a + " " + c + " " + b);
		else if (b > a && b > c && a > c) Console.WriteLine(b + " " + a + " " + c);
		else if (b > a && b > c && c > a) Console.WriteLine(b + " " + c + " " + a);
		else if (c > a && c > b && a > b) Console.WriteLine(c + " " + a + " " + b);
		else if (c > a && c > b && b > a) Console.WriteLine(c + " " + b + " " + a);
	}
}