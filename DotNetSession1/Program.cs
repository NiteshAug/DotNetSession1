using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSession1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String Value: ");
            string value = Console.ReadLine();
            LengthHelper.findLength(value);
        }
    }
}
