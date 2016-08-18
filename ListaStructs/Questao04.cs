using System;

public class Questao04 {
	public static void Main (string[] args) {
		Console.Write("Quantidade de alunos > ");
		int qtd = int.Parse(Console.ReadLine());
		Aluno[] alunos = new Aluno[qtd];

		for (int i = 0; i < alunos.Length; i++) {
			Console.Write("Matrícula > ");
			alunos[i].matricula = int.Parse(Console.ReadLine());
			Console.Write("Nome > ");
			alunos[i].nome = Console.ReadLine();
			Console.Write("Nota da primeira prova > ");
			alunos[i].nota1 = double.Parse(Console.ReadLine());
			Console.Write("Nota da segunda prova > ");
			alunos[i].nota2 = double.Parse(Console.ReadLine());

			alunos[i].media = (alunos[i].nota1 + alunos[i].nota2) / 2;
			Console.WriteLine("-------------");
		}

		Array.Sort<Aluno>(alunos, (x, y) => x.nota1.CompareTo(y.nota2));
		Console.WriteLine("Aluno com a maior nota na primeira prova: " + alunos[qtd - 1].nome);
		Array.Sort<Aluno>(alunos, (x, y) => x.media.CompareTo(y.media));
		Console.WriteLine("Aluno com a maior média: " + alunos[qtd - 1].nome);
		Console.WriteLine("Aluno com a menor média: " + alunos[0].nome);
	}

	struct Aluno {
		public int matricula;
		public string nome;
		public double nota1;
		public double nota2;
		public double media;
	}
}