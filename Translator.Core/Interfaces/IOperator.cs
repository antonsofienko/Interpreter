using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Core.Interfaces
{
    public interface IOperator
    {
        void Execute();
    }

    public interface IOperator<T>:IOperator
    {
        new T Execute();
    }
}
