using System;
using System.Linq;

namespace dot_net_study.Services
{
	public class Consulta
	{
		private Dictionary<int, string> users = new()
		{
			{1, "Giuseppin"},
			{2, "André"}
		};
		public Consulta() { }
		public void View()
		{
			Console.WriteLine("Escreva o id do usuário que deseja pesquisar: ");
			try
			{
				int userId = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(Search(userId));
			}
			catch (KeyNotFoundException ex)
			{
				Console.WriteLine("Usuário não encontrado, error: ", ex.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao buscar o usuário", ex.Message);
				throw new Exception("Test");
			}
		}
		public string Search(int a)
		{
			return users[a];
		}

	}
}

