using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.Arquivo;
using ConsoleApp29.Conversores;

namespace ConsoleApp29.View
{
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {
            Funcionarios f = new Funcionarios();
            Console.Clear();
            Console.WriteLine("CADASTRAR FUNCIONARIO: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Data Nascimento: ");
            f.DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Telefone:  ");
            f.Telefone = Console.ReadLine();
            Console.Write("CPF: ");
            f.CPF = Console.ReadLine();
            Console.Write("RG: ");
            f.RG = Console.ReadLine();
            Console.Write("Endereco: ");
            f.Endereco = Console.ReadLine();
            Console.Write("Cidade: ");
            f.Cidade = Console.ReadLine();
            Console.Write("Estado: ");
            f.Estado = Console.ReadLine();
            Console.Write("CEP: ");
            f.CEP = int.Parse(Console.ReadLine());
            Console.Write("Cargo: ");
            f.Cargo = Console.ReadLine();
            Console.Write("Salario: ");
            f.Salario = double.Parse(Console.ReadLine());
            Console.Write("Data Contratacao: ");
            f.DataContratacao = DateTime.Parse(Console.ReadLine());

            GerenciadorArquivo.GravarArquivo("funcionario", ClienteTexto.ConverterparaTextofunc(f));
        }

        public void ListarFuncionario()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE FUNCIONARIOS");

            string[] linhas = GerenciadorArquivo.LerArquivo("funcionario");

            foreach (string item in linhas)
            {
                Funcionarios func = Conversores.ClienteTexto.ConverterparaFuncionario(item);
                Console.WriteLine("Nome: " + func.Nome + "Cargo: " + func.Cargo);
            }

        }

    }
}
