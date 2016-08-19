using System;

public class Questao03 {
	public static void Main (string[] args) {
		Console.Write("Quantidade de pessoas > ");
		int qtd = int.Parse(Console.ReadLine());
		Agenda[] ag = new Agenda[qtd];

		for (int i = 0; i < ag.Length; i++) {
			Console.Write("Nome > ");
			ag[i].nome = Console.ReadLine();
			Console.Write("Endereço > ");
			ag[i].endereco = Console.ReadLine();
			Console.Write("Telefone > ");
			ag[i].telefone = Console.ReadLine();
			Console.WriteLine("-------------");
		}

		Array.Sort<Agenda>(ag, (x, y) => x.nome.CompareTo(y.nome));
		Console.Clear();

		for (int i = 0; i < ag.Length; i++) {
			Console.WriteLine("Nome: " + ag[i].nome);
			Console.WriteLine("Endereço: " + ag[i].endereco);
			Console.WriteLine("Telefone: " + ag[i].telefone);
			Console.WriteLine("-------------");
		}
	}

	struct Agenda {
		public string nome;
		public string endereco;
		public string telefone;
	}
}