using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleccion
{
	class Program
	{
		public static void leer(int[] x)
		{
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Ingrese el elemento {0}", i + 1);
				x[i] = Int32.Parse(Console.ReadLine());
			}
		}

		public static int[] ordenar(int[] x)
		{
			int[] vec = x;
			for (int i = 0; i < vec.Length - 1; i++)
			{
				int min = i;
				for (int j = i + 1; j < vec.Length; j++)
				{
					if (vec[j] < vec[min])
					{
						min = j;
					}
				}
				if (i != min)
				{
					int aux = vec[i];
					vec[i] = vec[min];
					vec[min] = aux;
				}
			}
			return vec;
		}

		public static void imprimir(int[] x)
		{
			foreach (int num in x)
			{
				Console.WriteLine("Elemento = {0}", num);
			}
		}


		static void Main(string[] args)
		{
			int[] x = new int[5];
			leer(x);
			ordenar(x);
			imprimir(x);

			Console.ReadKey();
		}
	}
}
