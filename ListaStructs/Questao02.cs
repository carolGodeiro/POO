using System;

public class Questao02 {
	public static void Main (string[] args) {
		Carro[] carros = new Carro[20];

		for (int i = 0; i < carros.Length; i++) {
			Console.Write("Marca > ");
			carros[i].marca = Console.ReadLine();
			Console.Write("Ano de fabricação > ");
			carros[i].anoFabricacao = int.Parse(Console.ReadLine());
			Console.Write("Ano do modelo > ");
			carros[i].anoModelo = int.Parse(Console.ReadLine());
			Console.Write("Cor > ");
			carros[i].cor = Console.ReadLine();
			Console.Write("Preço > ");
			carros[i].preco = double.Parse(Console.ReadLine());
			Console.WriteLine("-------------");
		}

		Console.Clear();
		for (int i = 0; i < carros.Length; i++) {
			Console.WriteLine("Marca: " + carros[i].marca);
			Console.WriteLine("Ano de fabricação: " + carros[i].anoFabricacao);
			Console.WriteLine("Ano do modelo: " + carros[i].anoModelo);
			Console.WriteLine("Cor: " + carros[i].cor);
			Console.WriteLine("Preço: " + carros[i].preco);
			Console.WriteLine("-------------");
		}
	}

	struct Carro {
		public string marca;
		public int anoFabricacao;
		public int anoModelo;
		public string cor;
		public double preco;
	}
}