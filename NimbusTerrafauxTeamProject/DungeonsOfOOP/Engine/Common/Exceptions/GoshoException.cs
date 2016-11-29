namespace Engine.Common.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class GoshoException : ArgumentOutOfRangeException, ISerializable
    {
        public GoshoException()
        {
        }

        public GoshoException(string paramName, string message = "You know in the Academy Gosho's just a joke, right!?") : base(paramName, message)
        {
        }
    }
}
