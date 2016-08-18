using System;

public class Questao01 {
	public static void Main (string[] args) {
		Pessoa[] pessoas = new Pessoa[50];

		for (int i = 0; i < pessoas.Length; i++) {
			Console.Write("Nome > ");
			pessoas[i].nome = Console.ReadLine();
			Console.Write("Altura > ");
			pessoas[i].altura = double.Parse(Console.ReadLine());
			Console.Write("Data de nascimento (dia) > ");
			pessoas[i].nasc.dia = int.Parse(Console.ReadLine());
			Console.Write("Data de nascimento (mês) > ");
			pessoas[i].nasc.mes = int.Parse(Console.ReadLine());
			Console.Write("Data de nascimento (ano) > ");
			pessoas[i].nasc.ano = int.Parse(Console.ReadLine());
			Console.WriteLine("-------------");
		}

		Console.Clear();
		for (int i = 0; i < pessoas.Length; i++) {
			Console.WriteLine("Nome: " + pessoas[i].nome);
			Console.WriteLine("Altura: " + pessoas[i].altura);
			Console.WriteLine("Data de nascimento: " + pessoas[i].nasc.dia + "/" + pessoas[i].nasc.mes + "/" + pessoas[i].nasc.ano);
			Console.WriteLine("-------------");
		}
	}

	struct Pessoa {
		public string nome;
		public double altura;
		public Nascimento nasc;
	}

	struct Nascimento {
		public int dia;
		public int mes;
		public int ano;
	}
}