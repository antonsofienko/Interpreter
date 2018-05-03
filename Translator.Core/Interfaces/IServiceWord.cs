using System;
using System.Collections.Generic;
using System.Text;

namespace Translator.Core.Interfaces
{
    public interface IServiceWord
    {
        string Name { get; }

        IList<IRPN> ToRPNList();
    }
}
