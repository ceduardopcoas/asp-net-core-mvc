using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public sealed class Funcionarios : Pessoa
    {

        public string Cargo { get; set; }
        public double Salario { get; set; }
        public DateTime DataContratacao { get; set; }


    }
}
