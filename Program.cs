// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Write Your Code Here
            //string myString = "Hello World";
            //decimal myDecimal = 0.77m;
            //bool myBoolean = true;
            
            //Write You Code Above This Line
            //Console.WriteLine(myString.GetType());
            //Console.WriteLine(myDecimal.GetType());
            //Console.WriteLine(myBoolean.GetType());

            string[] myGroceryArray = new string[2];

            myGroceryArray[0] = "Guacamole";
            myGroceryArray[1] = "Guacamole";
            
            Console.WriteLine(myGroceryArray[0]);
            Console.WriteLine(myGroceryArray[1]);
            //Console.WriteLine(myGroceryArray[2]);
        }
    }
}
