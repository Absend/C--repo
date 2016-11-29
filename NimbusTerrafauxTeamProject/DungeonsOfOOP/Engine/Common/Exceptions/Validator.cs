namespace Engine.Common.Exceptions
{
    using System;

    public static class Validator
    {
        public static void ValidateIsNotNull(object obj, string paramName = "The reference")
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName, paramName + " cannot be null.");
            }
        }

        public static void ValidateStringIsNotNullOrEmpty(string str, string strName = "The string")
        {
            Validator.ValidateIsNotNull(str, strName);

            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(strName, strName + " cannot be white space.");
            }
        }

        public static void ValidateStringIsTrueOrFalse(string str, string strName = "The string")
        {
            if (!((str.ToLower() == "true") ^ (str.ToLower() == "false")))
            {
                throw new ArgumentOutOfRangeException(strName, strName + " must be only \"true\" or \"false\"");
            }
        }

        public static void ValidateIntIsInRange(int number, int minValue, int maxValue, string intName= "The int")
        {
            if ((minValue > number) || (maxValue < number))
            {
                throw new ArgumentOutOfRangeException(intName, $"{intName} must be between {minValue} and {maxValue}");
            }
        }

        public static void ValidateStringIsIntParsable(string input)
        {
            int unneededResult;
            if (!int.TryParse(input, out unneededResult) && (input.ToLower() != "gosho"))
            {
                throw new ArgumentOutOfRangeException("Input", "Input must be integer");
            }
            else if (!int.TryParse(input, out unneededResult) && (input.ToLower() == "gosho"))
            {
                throw new GoshoException("Input");
            }
        }
    }
}
