﻿using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine("The string could not be converted to boolean.");
             
            }
            
        }
    }
}
