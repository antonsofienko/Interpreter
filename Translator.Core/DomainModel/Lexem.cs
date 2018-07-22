using System;
using System.Collections.Generic;
using System.Text;
using Translator.Core.Interfaces;

namespace Translator.Core.DomainModel
{
    public class Lexem : ILexem
    {
        public int Code { get; set; }
        public int Row { get; set; }
        public string Substring { get; set; }

        public Lexem( int row, string substring,int code)
        {
            this.Code = code;
            this.Row = row;
            this.Substring = substring;
        }
    }
}
