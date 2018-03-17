using System;

namespace MeuNamespace
{
	public class MinhaClasse
	{
		static void Main()
		{
			Console.Write("Informe um número para A entre 0 e 100: ");
			string input1 = Console.ReadLine();
			Console.Write("Informe um número para B entre 0 e 100: ");
			string input2 = Console.ReadLine();
			
			int num1 = 0;
			int num2 = 0; 
			
			if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2) && (num1 >= 0 && num1 <= 100) && (num2 >= 0 && num2 <= 100))
			{
				int result = num1 + num2;
				Console.WriteLine("A) " + num1);
				Console.WriteLine("B) " + num2);
				Console.WriteLine("Resultado: " + result);
			}
			else
			{
				Console.WriteLine("Ocorreu um problema. Um dos números informados não eram validos ou não eram números inteiros.");
				Console.WriteLine("A) " + num1);
				Console.WriteLine("B) " + num2);
			}
			
			Console.WriteLine("Pressione qualquer tecla para continuar...");
			Console.ReadKey();
		}
	}
}