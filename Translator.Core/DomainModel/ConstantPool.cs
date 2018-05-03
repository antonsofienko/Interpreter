using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Translator.Core.Interfaces;

namespace Translator.Core.DomainModel
{
    public class ConstantPool : IConstantPool
    {
        private Dictionary<object,IConstant> constDict = new Dictionary<object, IConstant>();


        public IList<IConstant> AllConstants
        {
            get
            {
                return constDict.Values.ToList(); ;
            }
        }

        public IConstant this[object index]
        {
            get
            {
                return constDict.ContainsKey(index) ? constDict[index] : null;
            }
            set
            {
                if (!constDict.ContainsKey(index)) constDict[index] = value;
            }
        }


    }
}
