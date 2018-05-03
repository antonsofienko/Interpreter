using System;
using System.Collections.Generic;
using Translator.Core.DomainModel;
using Translator.Core.Interfaces;

namespace LexicalAnalyser.FiniteStateMachine
{
    public class FiniteStateMachine : ILexicalAnalyzer
    {
        //interface implementation
        public IList<ILexem> Lexems { get; private set; }

        public IConstantPool Constants { get; private set; }

        public IVariablePool Variables { get; private set; }

        public IServiceWordPool ServiceWordPool { get; private set; }

        //------------------------------------------------
        IList<string> sourceCode;
        List<State> tos;//tabel of state

        public FiniteStateMachine(IList<string> sourceCode, IServiceWordPool serviceWordPool)
        {
            this.sourceCode = sourceCode;
            this.ServiceWordPool = serviceWordPool;
        }

        public bool Analyze()
        {
            Lexems = new List<ILexem>();
            IdentifierList = new List<Idnt>();
            ConstantList = new List<Const>();

            int row = 0;
            foreach (var line in sourceCode)
            {
                row++;
                //  List<LexicalUnit> tempList = new List<LexicalUnit>();

                for (int i = 0; i < line.Length;)
                    State.Execute(tos[0], ref row, line, null, ref i);

                Lexems.Add(new Lexem(row, "¶", 3));
            }

            return true;
        }

    }
}
