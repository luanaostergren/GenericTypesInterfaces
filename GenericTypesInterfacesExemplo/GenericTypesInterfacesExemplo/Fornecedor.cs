using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGeneric.ForcecedorClass
{
    public class Fornecedor : IEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
