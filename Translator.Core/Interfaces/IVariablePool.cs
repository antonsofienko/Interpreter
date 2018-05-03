using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Core.Interfaces
{
    public interface IVariablePool
    {
       IVariable this[string index]
        {
            get; set;
        }
        IVariable this[IIdentificator index]
        {
            get; set;
        }

        IList<IVariable> AllVariables { get; }
    }
}
