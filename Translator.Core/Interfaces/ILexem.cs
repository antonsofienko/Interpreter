using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Core.Interfaces
{
 public  interface ILexem
    {
        int Number { get; set; }
        int Row { get; set; }
        string Substring { get; set; }
    }
}
