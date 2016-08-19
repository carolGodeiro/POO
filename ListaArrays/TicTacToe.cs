using System;

public class TicTacToe {
	private static char[,] tabuleiro = new char[3, 3];
	private static int jogadorAtual, placarX = 0, placarO = 0, empates = 0;

	private static void novoJogo() {
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				tabuleiro[i, j] = '-';
			}
		}

		jogadorAtual = 1;
	}

	private static void fazerJogada (int linha, int coluna) {
		if (linha >= 1 && linha <= 3 && coluna >= 1 && coluna <= 3) {
			if (tabuleiro[linha - 1, coluna - 1] == '-') {
				if (jogadorAtual == 1) {
					tabuleiro[linha - 1, coluna - 1] = 'X';
					jogadorAtual = 2;
				} else {
					tabuleiro[linha - 1, coluna - 1] = 'O';
					jogadorAtual = 1;
				}
			}
		}
	}

	private static char verificar() {
		char r = '=';

		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				if (tabuleiro[i, j] == '-') {
					r = '-';
				}
			}
		}

		/* HORIZONTAL */
		if (tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 0] == tabuleiro[0, 2]) {
			r = tabuleiro[0, 0];
		} else if (tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 0] == tabuleiro[1, 2]) {
			r = tabuleiro[1, 0];
		} else if (tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 0] == tabuleiro[2, 2]) {
			r = tabuleiro[2, 0];
		}

		/* VERTICAL */
		if (tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[0, 0] == tabuleiro[2, 0]) {
			r = tabuleiro[0, 0];
		} else if (tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[0, 1] == tabuleiro[2, 1]) {
			r = tabuleiro[0, 1];
		} else if (tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[0, 2] == tabuleiro[2, 2]) {
			r = tabuleiro[0, 2];
		}

		/* DIAGONAL */
		if (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[0, 0] == tabuleiro[2, 2]) {
			r = tabuleiro[0, 0];
		} else if (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[0, 2] == tabuleiro[2, 0]) {
			r = tabuleiro[0, 2];
		}

		return r;
	}

	private static void mostrarTabuleiro() {
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				Console.Write(tabuleiro[i, j] + " ");
			}

			Console.WriteLine();
		}
	}

	private static void jogar() {
		novoJogo();
		int linha, coluna;
		string jogada;

		while (true) {
			mostrarTabuleiro();
			Console.Write("Jogada: ");
			jogada = Console.ReadLine();

			char j = Char.ToUpper(jogada[0]);
			if (j == 'A') {
				linha = 1;
			} else if (j == 'B') {
				linha = 2;
			} else if (j == 'C') {
				linha = 3;
			} else {
				linha = -1;
			}

			coluna = int.Parse(jogada[1].ToString());
			fazerJogada(linha, coluna);
			Console.Clear();

			char r = verificar();
			switch (r) {
				case '=':
					Console.WriteLine("Empate!");
					empates++;
					break;
				case 'X':
					Console.WriteLine("O jogador X venceu!");
					placarX++;
					break;
				case 'O':
					Console.WriteLine("O jogador O venceu!");
					placarO++;
					break;
			}

			if (r != '-') {
				break;
			}
		}

		Console.WriteLine("---- PLACAR ----");
		Console.WriteLine("Jogador X: " + placarX + "\nJogador O: " + placarO + "\nEmpates: " + empates + "\n");
		Console.Write("Deseja jogar novamente? <S/n> ");
		string jog = Console.ReadLine();
		if (jog.ToUpper() == "S") {
			Console.Clear();
			jogar();
		}
	}

	public static void Main (string[] args) {
		Console.WriteLine(" _   _      _             _             ");
		Console.WriteLine("| | (_)    | |           | |            ");
		Console.WriteLine("| |_ _  ___| |_ __ _  ___| |_ ___   ___ ");
		Console.WriteLine("| __| |/ __| __/ _` |/ __| __/ _ \\ / _ \\");
		Console.WriteLine("| |_| | (__| || (_| | (__| || (_) |  __/");
		Console.WriteLine(" \\__|_|\\___|\\__\\__,_|\\___|\\__\\___/ \\___|");
		Console.WriteLine("     Desenvolvido por Cristian Henrique");
		Console.WriteLine("        cristianmsbr@gmail.com\n\n\n");

		Console.Write("Digite 1 para jogar ou 0 para sair > ");
		int r = int.Parse(Console.ReadLine());
		if (r == 1) {
			Console.Clear();
			jogar();
		}
	}
}