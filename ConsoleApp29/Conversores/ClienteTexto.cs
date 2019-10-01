using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace ConsoleApp29.Conversores
{
    class ClienteTexto
    {

        public static string ConverterparaTexto(Clientes cliente)
        {
            string texto = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                cliente.Nome,
                cliente.Telefone,
                cliente.CPF,
                cliente.RG,
                cliente.DataNascimento,
                cliente.Endereco,
                cliente.Cidade,
                cliente.Estado,
                cliente.CEP) ;
            return texto;

        }
        public static string ConverterparaTextofunc(Funcionarios func)
        {
            string texto = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                func.Nome,
                func.Telefone,
                func.CPF,
                func.RG,
                func.DataNascimento,
                func.Endereco,
                func.Cidade,
                func.Estado,
                func.CEP,
                func.Salario,
                func.Cargo,
                func.DataContratacao);
            return texto;

        }

        public static Clientes ConverterparaCliente(string linha)
        {
            string[] elementos = linha.Split(',');
            Clientes cliente = new Clientes();
            cliente.Nome = elementos[0];
            cliente.Telefone = elementos[1];
            cliente.CPF = elementos[2];
            cliente.RG = elementos[3];
            cliente.DataNascimento = DateTime.Parse(elementos[4]);
            cliente.Endereco = elementos[5];
            cliente.Cidade = elementos[6];
            cliente.Estado = elementos[7];
            cliente.CEP = int.Parse(elementos[8]);

            return cliente;
        }
        public static Funcionarios ConverterparaFuncionario(string linha)
        {
            string[] elementos = linha.Split(',');
            Funcionarios func = new Funcionarios();
            func.Nome = elementos[0];
            func.Telefone = elementos[1];
            func.CPF = elementos[2];
            func.RG = elementos[3];
            func.DataNascimento = DateTime.Parse(elementos[4]);
            func.Endereco = elementos[5];
            func.Cidade = elementos[6];
            func.Estado = elementos[7];
            func.CEP = int.Parse(elementos[8]);
            func.Salario = double.Parse(elementos[9]);
            func.Cargo = elementos[10];
            func.DataContratacao = DateTime.Parse(elementos[11]);


            return func;
        }


    }
}
