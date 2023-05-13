using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Simulado
{
	internal class Program3
	{
		static void Main(string[] args)
		{
			//ALGORITMO DE ORDENAÇÂO CRESCENTE
			Console.WriteLine("ALGORITMO DE ORDENAÇÃO CRESCENTE\n");
			double[] srcNums = new double[12] { 1890, 136, 0, 20, 23.19, 3.1, 2.5, 0, 200, 17.51, 30319, 1915 };
			double[] orgNums = new double[srcNums.Length];
			Array.Copy(srcNums, orgNums, srcNums.Length);
			for (int i = 0; i < orgNums.Length - 1; i++)
			{
				for (int j = 0; j < (orgNums.Length - i) - 1; j++)
				{
					if (orgNums[j] > orgNums[j + 1])
					{
						double tmpNum = orgNums[j];
						orgNums[j] = orgNums[j + 1];
						orgNums[j + 1] = tmpNum;
					}
				}
			}
			Console.Write("Lista de números desordenados: ");
			for (int i = 0; i < srcNums.Length; i++)
			{
				Console.Write($"{srcNums[i]} ");
			}
			Console.Write("\n\n");
			Console.Write("Lista de números ordenados: ");
			for (int i = 0; i < orgNums.Length; i++)
			{
				Console.Write($"{orgNums[i]} ");
			}
			Console.ReadKey();
		}
	}
}
