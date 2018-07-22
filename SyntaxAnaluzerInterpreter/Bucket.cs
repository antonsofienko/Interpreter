using System;
using System.Collections.Generic;
using Translator.Core.DomainModel;
using Translator.Core.Interfaces;

namespace SyntaxAnalyzerInterpreter
{

    public abstract class ChainElementAbs
    {
        public int PositionId{ get; private set; }
        public ChainElementAbs PreviousElement { get;/*private*/ set; }//mayebe better hide set method, but I need it;
        public ChainElementAbs[] FollowingPaths { get; private set; }


        /// <summary>
        /// Get next element  in Sequence
        /// </summary>
        /// <param name="number"> Number of way</param>
        /// <returns>next element by number or null if way doesn`t exist</returns>
        public ChainElementAbs GetFillowingChainByNumber(int number)
        {
            if (number >= FollowingPaths.Length) return null;
            else return FollowingPaths[number];
        }


        public ChainElementAbs(int positionId) => PositionId = positionId;
        public ChainElementAbs(int positionId,ChainElementAbs previousElement=null,ChainElementAbs[] followingPathsArray=null)
        {
            this.PositionId = positionId;
            this.FollowingPaths = followingPathsArray;
            this.PreviousElement = previousElement;
        }



        public void SetSeveralNextElements(params ChainElementAbs[] folwingPaths)
        {
            FollowingPaths = folwingPaths;

            foreach (var item in folwingPaths)
                item.PreviousElement = this;
        }

        public ChainElementAbs SetNextElement(ChainElementAbs nextElement)
        {
            this.FollowingPaths =new ChainElementAbs[] { nextElement };
            nextElement.PreviousElement = this;

            return nextElement;
        }


        public abstract bool Add(ILexem lexem);
        
    }

    public class RequiredServiceWord
    {
        public IServiceWord RequiredLexem { get; private set; }
        public bool IsFull { get; private set; }

        public RequiredServiceWord(IServiceWord requiredServiceWord)
        {
            this.RequiredLexem = requiredServiceWord;
        }

        public bool Add(ILexem lexem)
        {
            if (lexem.Substring == RequiredLexem.Name)
            {
                IsFull = true;
                return IsFull;
            }
            else throw new Exception($"Enexpected lexem '{lexem.Substring}' in row {lexem.Row}. Expected '{RequiredLexem.Name}'");
        }

    }





    //public abstract class BucketContainerAbs
    //{


    //}

    //public class BucketContainerVoid:BucketContainerAbs
    //{
    //}

    public class Container:ChainElementAbs
    {
        public Container(int positionId):base(positionId) { }

        public Container ParentContainer { get; set; }
        public VariablePool LocalVariablePool { get; set; }//todo:maybe should hide set method;
        public List<IOperator> OperatorList { get; set; } = new List<IOperator>();
        public List<IOperator> AvaibleOperators { get; set; } = new List<IOperator>();

        public override bool Add(ILexem lexem)
        {
            throw new NotImplementedException();
        }

        public  void Execute()
        {
            for (int i = 0; i <= OperatorList.Count; i++)
                OperatorList[i].Execute();
        }
    }

    public class Container<T> : Container// : BucketContainerAbs
    {
        public Container(int positionId):base(positionId){}

        public new  T Execute()
        {
            int i = 0;
            for (; i < OperatorList.Count; i++)
            {
                OperatorList[i].Execute();
            }


            if (OperatorList[i] is IOperator<T> oprtor) return oprtor.Execute();
            else return default(T);
        }
    }



}
