using System;
using System.Collections.Generic;
using System.Text;
using Translator.Core.Interfaces;

namespace Translator.Core.DomainModel
{
    class StringConstant : IConstant<String>
    {
        public Types Type { get => Types.@string; }

        public string Value { get; private set; }
        public StringConstant(string value) => Value = value;

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    class IntConstant : IConstant<int>
    {
        public Types  Type { get => Types.@int; }

        public int Value { get; private set; }
        public IntConstant(int value) => Value = value;

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    class FloatConstant : IConstant<double>
    {
        public Types Type { get => Types.@float; }

        public double Value { get; private set; }

        public FloatConstant(double value) => Value = value;

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
