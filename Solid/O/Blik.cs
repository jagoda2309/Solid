﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.O
{
    class Blik : IPay
    {
        public string Payment(decimal amount)
        {
            return $"Płatnośc Blikiem - {amount}";
        }
    }
}
