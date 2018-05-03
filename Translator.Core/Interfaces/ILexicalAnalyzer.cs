using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Core.Interfaces
{
    public interface ILexicalAnalyzer
    {
        IList<ILexem> Lexems { get; }
        IConstantPool Constants { get; }
        IVariablePool Variables { get; }

        IServiceWordPool ServiceWordPool { get; }

        bool Analyze();
    }
}
