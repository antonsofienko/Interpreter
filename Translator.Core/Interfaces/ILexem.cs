using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Core.Interfaces
{
 public  interface ILexem
    {
        int Code { get; set; }
        int Row { get; set; }
        string Substring { get; set; }
    }
}
