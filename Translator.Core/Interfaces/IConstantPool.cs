using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Core.Interfaces
{
    public interface IConstantPool
    {
        IConstant this[object index]
        {
            get; set;
        }

        IList<IConstant> AllConstants { get; }
    }
}
