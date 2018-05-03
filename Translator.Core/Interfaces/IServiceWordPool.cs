using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Core.Interfaces
{
    public interface IServiceWordPool
    {
        IServiceWord this[string index]
        {
            get;set;
        }

        IList<IServiceWord> AllServiceWords { get; }
    }
}
