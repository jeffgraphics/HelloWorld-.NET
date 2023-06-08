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

            string[] myGroceryArray = new string[3];

            myGroceryArray[0] = "Guacamole";
            myGroceryArray[1] = "Ice Cream";
            
            Console.WriteLine("My First Array");
            Console.WriteLine(myGroceryArray[0]);
            Console.WriteLine(myGroceryArray[1]);
            Console.WriteLine(myGroceryArray[2]);

            string[] mySecondGroceryArray = {"Apples", ""};
            Console.WriteLine("My Second Array");

            Console.WriteLine(mySecondGroceryArray[0]);
            Console.WriteLine(mySecondGroceryArray[1]);

            //How to create a list and declare a list
            List<string> myGroceryList = new List<string>() {"Milk", "Cheese"};
            //How to add a new item to the list
            myGroceryList.Add("Oranges");
            
            Console.WriteLine("myGroceryList");
            Console.WriteLine(myGroceryList[0]);
            Console.WriteLine(myGroceryList[1]);
            Console.WriteLine(myGroceryList[2]);

            //Declare and using IEnumerable
            IEnumerable<string> myGroceryIEnumerable = myGroceryList;

            Console.WriteLine(myGroceryIEnumerable.First());

            //Two DimensionalArray
            string[,] myTwoDimensionalArray = new string[2,1] {
                {"Milk", "Cheese"}
                {"Ice Cream","Guacamole"}            
            };

            Console.WriteLine(myTwoDimensionalArray[1,0]);

            //Dictionary
            Dictionary<string, string> myGroceryDictionary = new Dictionary<string, string>{
                {"Cheese", "Dairy"}
                
            };

        
        }
    }
}
