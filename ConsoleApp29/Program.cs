using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp29.View;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcoes = 0;

            while (opcoes != 5)
            {
                Console.WriteLine("O que desejo fazer? 01 - Cadastrar Cliente, 02 - Listar Cliente, 03 - Cadastrar Funcionario, 04 - " +
"Listar Funcioario, 05 - Sair do Projeto. ");
                Console.Write("Digite uma opcao: ");
                opcoes = int.Parse(Console.ReadLine());
                ManterCliente telaC = new ManterCliente();
                ManterFuncionario telaF = new ManterFuncionario(); 

                switch (opcoes)
                {
                    case 1:
                       
                        telaC.CadastrarCliente();
                        break;
                    case 2:
                       
                        telaC.ListarClientes();
                        break;
                    case 3:
                        telaF.CadastrarFuncionario();
                        break;
                    case 4:
                        telaF.ListarFuncionario();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opcao nao encontrada: ");
                        break;
                }

            }
   





        }
    }
}
