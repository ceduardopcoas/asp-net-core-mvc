using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using ConsoleApp29.Conversores;
using Biblioteca.Arquivo;

namespace ConsoleApp29.View
{
    class ManterCliente
    {

        public void CadastrarCliente()
        {
            Clientes c = new Clientes();
            Console.Clear();
            Console.WriteLine("CADASTRAR CLIENTE: ");
            Console.Write("Nome: ");
            c.Nome = Console.ReadLine();
            Console.Write("Data Nascimento: ");
            c.DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Telefone: ");
            c.Telefone = Console.ReadLine();
            Console.Write("CPF: ");
            c.CPF = Console.ReadLine();
            Console.Write("RG: ");
            c.RG = Console.ReadLine();
            Console.Write("Endereco: ");
            c.Endereco = Console.ReadLine();
            Console.Write("Cidade: ");
            c.Cidade = Console.ReadLine();
            Console.Write("Estado: ");
            c.Estado = Console.ReadLine();
            Console.Write("CEP: ");
            c.CEP = int.Parse(Console.ReadLine());

            GerenciadorArquivo.GravarArquivo("cliente",ClienteTexto.ConverterparaTexto(c));

        }

        public void ListarClientes()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE CLIENTES");

            string[] linhas = GerenciadorArquivo.LerArquivo("cliente");

            foreach (string item in linhas)
            {
                Clientes cliente = Conversores.ClienteTexto.ConverterparaCliente(item);
                Console.WriteLine("Nome: " + cliente.Nome);
            }

        }
    }
}
