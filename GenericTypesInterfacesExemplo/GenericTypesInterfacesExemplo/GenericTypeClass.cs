using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleGeneric.GenericTypeClass
{
    /// <summary>
    ///     Escrevendo no console o Nome de clientes e fornecedores que implementam a interface IEntidade.
    /// </summary>
    /// <typeparam name="TEntidade"></typeparam>
    public class GenericEntidade<TEntidade> where TEntidade : class
    {
        public void WriteNome(IEnumerable<TEntidade> obj)
        {
            foreach(var item in obj)
            {
                if (item is IEntidade entidade)
                {
                    Console.WriteLine(entidade.Nome);
                }
            }            
        }
    }
}
