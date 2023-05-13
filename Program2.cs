using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Simulado
{
	internal class Program2
	{
		static void Main(string[] args)
		{
			//2 - PALÍNDROMO
			Console.WriteLine("VERIFICADOR DE PALÍNDROMOS\n");
			while (true)
			{
				Console.Write("Insira uma palavra ou uma frase (não use acentos):\n>");
				string usrString = Console.ReadLine().ToLower();
				if (usrString.Contains(" ") || usrString.Contains("-") || usrString.Contains(",") || usrString.Contains("."))
				{
					usrString = usrString.Replace(" ", "").Replace("-", "").Replace(",", "").Replace(".", "");
				}
				char[] fwrString = usrString.ToCharArray();
				char[] bckString = usrString.Reverse().ToArray();
				bool isPalindrome = true;
				for (int i = 0; i < fwrString.Length; i++)
				{
					if (fwrString[i] != bckString[i])
					{
						isPalindrome = false;
						break;
					}
				}
				if (isPalindrome)
				{
					Console.WriteLine("\nA palavra ou frase inserida é um palíndromo.\n");
				}
				else
				{
					Console.WriteLine("\nA palavra ou frase inserida não é um palíndromo.\n");
				}
			}
		}
	}
}
