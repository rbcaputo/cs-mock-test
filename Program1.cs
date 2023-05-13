using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Simulado
{
	internal class Program1
	{
		static void Main(string[] args)
		{
			//1 - JOGO DA FORCA
			Console.WriteLine("JOGO DA FORCA\n");
			List<string> words = new List<string>() { "CACHORRO", "GATO", "HAMSTER", "BANANA", "MORANGO", "LARANJA", "CARRO", "MOTOCICLETA", "PATINETE", "VERMELHO", "AMARELO", "AZUL" };
			Random rnd = new Random();
			string rndWord = words[rnd.Next(words.Count)];
			int lttCount = rndWord.Length;
			char[] userWord = new char[rndWord.Length];
			List<char> wrongLetters = new List<char>();
			bool guessed = false;
			for (int i = 0; i < rndWord.Length; i++)
			{
				userWord[i] = '_';
			}
			while (!guessed)
			{
				Console.Write($"Palavra ({lttCount}): ");
				for (int i = 0; i < rndWord.Length; i++)
				{
					Console.Write($"{userWord[i]}");
				}
				Console.Write("\n\n");
				Console.Write($"Letras erradas ({wrongLetters.Count}): ");
				foreach (char c in wrongLetters)
				{
					Console.Write($"{c} ");
				}
				Console.Write("\n\n");
				Console.Write("Digite uma letra:\n>");
				char letter = char.Parse(Console.ReadLine().ToUpper());
				Console.Write('\n');
				if (rndWord.Contains(letter))
				{
					for (int i = 0; i < rndWord.Length; i++)
					{
						if (rndWord[i] == letter && userWord[i] == '_')
						{
							userWord[i] = letter;
							lttCount--;
						}
						else
						{
							userWord[i] = userWord[i];
						}
					}
				}
				else
				{
					wrongLetters.Add(letter);
				}

				if (!userWord.Contains('_'))
				{
					guessed = true;
					Console.WriteLine($"Parabéns! Você descobriu a palavra {rndWord}.\nFim de jogo!");
					Console.ReadKey();
				}
				else
				{
					guessed = false;
				}
			}
		}
	}
}
