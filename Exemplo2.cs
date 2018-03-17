using System;

namespace MeuNamespace
{
	public class MinhaClasse
	{
		static void Main()
		{
			Console.Write("Informe seu nome: ");
			string nome = Console.ReadLine();
			
			Console.WriteLine("Olá " + nome + " bem-vindo ao C# Brasil!");
			Console.Write("Pressione qualquer tecla para continuar...");
			Console.ReadKey();
		}
	}
}