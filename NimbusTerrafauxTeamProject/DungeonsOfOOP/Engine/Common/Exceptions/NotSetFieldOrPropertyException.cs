namespace Engine.Common.Exceptions
{
    using System;

    public class NotSetFieldOrPropertyException : ApplicationException
    {
        public const string PageSizeException = "Page Size is not set";
        public const string HeaderImageException = "Header Image is not set";

        public NotSetFieldOrPropertyException(string msg) : base(msg)
        {
            
        }
    }
}
