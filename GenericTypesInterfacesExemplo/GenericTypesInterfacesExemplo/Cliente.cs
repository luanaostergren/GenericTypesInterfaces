﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGeneric.ClienteClass
{
    public class Cliente : IEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
