using System;
using System.Drawing;
using System.Xml.Linq;
using dot_net_study.Models;

namespace dot_net_study.Services
{
	public class Compare
	{
        public Compare()
		{
		}
		public void View() {
			Console.Write("Digite um número inteiro: ");
			int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro número inteiro: ");
            int b = Convert.ToInt32(Console.ReadLine());
			if (a > b)
				Console.WriteLine("O primeiro valor é maior que o segundo");
			else if (a<b)
                Console.WriteLine("O segundo valor é maior que o primeiro");
			else
                Console.WriteLine("Ambos são iguais");
        }

    }
}

