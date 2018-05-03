using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Translator.Core.Interfaces;

namespace Translator.Core.DomainModel
{
    public class ServiceWordPool : IServiceWordPool
    {

        private Dictionary<string, IServiceWord> serviceWordDict = new Dictionary<string, IServiceWord>();
        public IList<IServiceWord> AllServiceWords
        {
            get
            {
                return serviceWordDict.Values.ToList(); ;
            }
        }

        public IServiceWord this[string index]
        {
            get
            {
                return serviceWordDict.ContainsKey(index) ? serviceWordDict[index] : null;
            }
            set
            {
                if (!serviceWordDict.ContainsKey(index)) serviceWordDict[index] = value;
            }
        }
    }
}
