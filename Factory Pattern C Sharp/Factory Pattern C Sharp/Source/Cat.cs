﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_C_Sharp.Source
{
    class Cat:Animal
    {
        public override string speak()
        {
            return "Meow";
        }
    }
}
