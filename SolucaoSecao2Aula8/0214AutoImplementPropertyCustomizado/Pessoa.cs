﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0214AutoImplementPropertyCustomizado
{
    class Pessoa
    {
        private string _nome;
        public string Nome {
            get { return _nome; }
            set { _nome = value.Trim().ToUpper(); }
        }
    }
}
