using System;
using System.Collections.Generic;
using System.Text;
using Translator.Core.Interfaces;

namespace SyntaxAnalizerInterpreter
{
  public   class OperatorFactory
    {

        public OperatorFactory()
        {
            //todo:add auto finding operator types in assembly

            //foreach(Type type in this.GetType().Assembly.GetTypes())
            //{

            //}
        }
        public List<IOperator> Operators { get; set; } = new List<IOperator>();
    }
}
