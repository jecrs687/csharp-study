using System;
using System.Drawing;
using System.Xml.Linq;
using dot_net_study.Models;

namespace dot_net_study.Services
{
	public class Buy
	{
		private List<string> products = new() {
			"maça", "pera", "banana"
		};

        public Buy()
		{
		}
		public void View() {
			Console.Write("\n Escolha uma opção: \n 1 - Listar tudo \n 2 - Validar se existe na lista \n 3 - Adicionar \n 4 - Atualizar \n 5 - Deletar \n 6 - Sair \n");
			int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ListAll();
                    break;
                case 2:
                    ListByName();
                    break;
                case 3:
                    Insert();
                    break;
                case 4:
                    Update();
                    break;
                case 5:
                    Remove();
                    break;
                case 6:
                    return;
                default:
                    break;
            }
            View();
        }
        private void ListAll() {
			string listConcat = string.Join(", ", products);
            Console.WriteLine(listConcat);
		}
        private void ListByName() {
            Console.WriteLine("Qual nome deseja validar se existe?");
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("O nome do produto deve ser informado");
                ListByName();
            }
            else
                Console.WriteLine(findElement(name) ? "Existe" : "Não existe");
		}
        private void Insert() {
            Console.WriteLine("Qual item deseja adicionar ?");
            var product = Console.ReadLine();
            if (string.IsNullOrEmpty(product))
            {
                Console.WriteLine("O novo produto deve ser informado");
                Insert();
            }
            else
            {
                if (!findElement(product))
                {
                    products.Add(product);
                    ListAll();
                }
                else
                {
                    Console.WriteLine($"{product} já existe na lista");
                }
            }
        }
        private void Update() {
            Console.WriteLine("Qual item deseja atualizar?");
            var name = Console.ReadLine();
            Console.WriteLine("Qual seria o novo valor ?");
            var newName = Console.ReadLine();
            int index = products.FindIndex(x => x == name);
            if (string.IsNullOrEmpty(newName))
            {
                Console.WriteLine("O novo nome deve ser informado");
                Update();
            }
            else
            {
                if (index != -1)
                    products[index] = newName;
                else
                    Console.WriteLine($"{name} não existe na lista");
            }           
            
        }
        private void Remove()
        {
            Console.WriteLine("Qual item deseja deletar?");
            var name = Console.ReadLine();
            int index = products.FindIndex(x => x == name);
            if (index != -1)
            {
                products.RemoveAt(index);
                ListAll();
            }
            else
            {
                Console.WriteLine($"{name} não existe");
            }
        }
        private bool findElement(string name) => products.Any(x => x == name);
    }
}

