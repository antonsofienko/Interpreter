using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Core.Interfaces
{
    public interface IConstant
    {
        Types Type { get; }
        object Value { get; }
    }

    public interface IConstant<T>:IConstant
    {
         new Types Type { get; }
         new  T Value { get;  }
    }
}
