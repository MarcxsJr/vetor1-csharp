﻿using projeto;
using System;
using System.Globalization;

namespace projeto
{
    class Pensionato{

        public string? Nome {get;set;}
        public string? Email {get;set;}

        public override string ToString()
        {
            return Nome + ", " + Email;
        }


    }
}   