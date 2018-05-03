using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Translator.Core.Interfaces;

namespace Translator.Core.DomainModel
{
    class VariablePool : IVariablePool
    {
        private Dictionary<string, IVariable> variableDict = new Dictionary<string, IVariable>();


        public IList<IVariable> AllVariables {
            get
            {
                return variableDict.Values.ToList(); ;
            }
        }

        public IVariable this[string index]
        {
            get
            {
                return variableDict.ContainsKey(index) ? variableDict[index] : null;
            }
            set
            {
                if (!variableDict.ContainsKey(index)) variableDict[index] = value;
            }
        }
        public IVariable this[IIdentificator index]
        {
            get
            {
                return variableDict.ContainsKey(index.Name) ? variableDict[index.Name] : null;
            }
            set
            {
                if (!variableDict.ContainsKey(index.Name)) variableDict[index.Name] = value;
            }
        }

    }
}
