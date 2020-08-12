using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGeneric
{
    public interface IEntidade
    {
        int Id { get; set; }
        string Nome { get; set; }
    }
}
