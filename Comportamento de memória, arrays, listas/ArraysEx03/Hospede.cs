﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx03
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
