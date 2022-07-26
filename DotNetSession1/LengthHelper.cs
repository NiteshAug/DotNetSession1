using System;

namespace DotNetSession1
{
    public static class LengthHelper
    {
        public static int findLength(String value)
        {
            int stringLength = value.Length;
            Console.WriteLine("String Length is: " + stringLength);
            return stringLength;
        }
    }
}
