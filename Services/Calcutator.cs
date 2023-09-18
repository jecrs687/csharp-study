using System;
namespace dot_net_study.Services
{
	public class Calcutator
	{
		public Calcutator()
		{
		}
		public void View() {
			Console.Write("\n Escolha uma opção: \n 1 - soma \n 2 - subtração \n 3 - multiplicação \n 4 - divisão \n");
			int option = Convert.ToInt32(Console.ReadLine());
			Console.Write("\n Escreva dois números consecutivos: \n");
			int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
			Dictionary<int, int> witchOption = new Dictionary<int, int>()
			{
			{1, Sum(a,b)},
			{2, Sub(a,b)},
			{3, Mul(a,b)},
			{4, Div(a,b)}
			};
            Console.WriteLine(witchOption[option]);
        }
        private  int Sum(int a, int b) {
			return a + b;
		}
        private  int Sub(int a, int b) {
			return a - b;
		}
        private  int Mul(int a, int b) {
			return a * b;
        }
        private  int Div(int a, int b) {
			return a / b;
        }

    }
}

