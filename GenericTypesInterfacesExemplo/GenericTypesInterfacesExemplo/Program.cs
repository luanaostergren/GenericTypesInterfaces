using ConsoleGeneric.ClienteClass;
using ConsoleGeneric.ForcecedorClass;
using ConsoleGeneric.GenericTypeClass;
using System;
using System.Collections.Generic;

namespace ConsoleGeneric
{
    class Program
    {
        public static void Main(string[] args)
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Id = 1, Nome = "João" });

            var fornecedores = new List<Fornecedor>();
            fornecedores.Add(new Fornecedor() { Id = 1, Nome = "Pedro" });
            
            new GenericEntidade<Cliente>().WriteNome(clientes);
            new GenericEntidade<Fornecedor>().WriteNome(fornecedores);

            Console.ReadKey();

        }
    }
}
