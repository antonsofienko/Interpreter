using System;
using System.Collections.Generic;
using System.Text;
using Translator.Core.Interfaces;

namespace Translator.Core.DomainModel
{
    public class Lexem : ILexem
    {
        public int Number { get; set; }
        public int Row { get; set; }
        public string Substring { get; set; }
    }
}
