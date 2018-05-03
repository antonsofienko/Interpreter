using System;

namespace SyntaxAnaluzerInterpreter
{
    

    public abstract class BucketContainerAbs
    {
    }

    public class BucketContainerVoid:BucketContainerAbs
    {
    }

    public class BucketContainer<T> : BucketContainerAbs
    {

    }
}
