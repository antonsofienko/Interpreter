using System;
using System.Collections.Generic;
using System.Text;
using Translator.Core.Interfaces;

namespace Translator.Core.DomainModel
{
    public class ServiceWord : IServiceWord
    {
        public string Name { get; set; }

        public IList<IRPN> ToRPNList()
        {
            throw new NotImplementedException();
        }
    }
}
