using System;
using System.Collections.Generic;
using System.Text;
using Translator.Core.Interfaces;

namespace Translator.Core.DomainModel
{
    public class IntVariable : IVariable<int>
    {
        public Types Type => Types.@int;

        public int Value { get; set; }
        public IntVariable(int value) => Value = value;

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class FloatVariable : IVariable<double>
    {
        public Types Type => Types.@int;

        public double Value { get; set; }
        public FloatVariable(double value) => Value = value;

        public override string ToString()
        {
            return Value.ToString();
        }
    }

}
