using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Core.Interfaces
{
    public interface IVariable
    {
        Types Type { get; }
        object Value { get; set; }

    }
    public interface IVariable<T>
    {
        Types Type { get; }
        T Value { get; set; }

    }
}
