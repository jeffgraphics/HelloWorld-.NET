// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {

            //IF statements 

            int myInt = 5;
            int mySecondInt = 10;

            Console.WriteLine(myInt);
            
            // Write Your Code Here
            // string myString = "Hello World";
            // decimal myDecimal = 0.77m;
            // bool myBoolean = true;
            
            // Write You Code Above This Line
            // Console.WriteLine(myString.GetType());
            // Console.WriteLine(myDecimal.GetType());
            // Console.WriteLine(myBoolean.GetType());
            
            // string[] myGroceryArray = new string[2];
            // // string[] myGroceryArray = new string[3];

            // myGroceryArray[0] = "Guacamole";
            // myGroceryArray[1] = "Ice Cream";
            
            // Console.WriteLine("My First Array");
            // Console.WriteLine(myGroceryArray[0]);
            // Console.WriteLine(myGroceryArray[1]);
            // // Console.WriteLine(myGroceryArray[2]);

            // string[] mySecondGroceryArray = {"Apples", ""};
            // Console.WriteLine("My Second Array");

            // Console.WriteLine(mySecondGroceryArray[0]);
            // Console.WriteLine(mySecondGroceryArray[1]);

            // //How to create a list and declare a list
            // List<string> myGroceryList = new List<string>() {"Milk", "Cheese"};
            // //How to add a new item to the list
            // myGroceryList.Add("Oranges");
            
            // Console.WriteLine("myGroceryList");
            // Console.WriteLine(myGroceryList[0]);
            // Console.WriteLine(myGroceryList[1]);
            // Console.WriteLine(myGroceryList[2]);

            // //Declare and using IEnumerable
            // IEnumerable<string> myGroceryIEnumerable = myGroceryList;

            // Console.WriteLine(myGroceryIEnumerable.First());

            // //Two DimensionalArray
            // string[,] myTwoDimensionalArray = new string[2,2] {
            //     {"Milk", "Cheese"},
            //     {"Ice Cream","Guacamole"}            
            // };
            // Console.WriteLine("TwoDimensional");
            // Console.WriteLine(myTwoDimensionalArray[1,0]);
            // Console.WriteLine("");

            // //Dictionary
            // Dictionary<string, string> myGroceryDictionary = new Dictionary<string, string>(){
            //     {"Cheese", "Dairy"}                
            // };

            // Console.WriteLine(myGroceryDictionary["Cheese"]);


            //OPERATORS AND CONDITIONALS

            // int myInt = 5;
            // int mySecondInt = 10;

            // //and/OR statements
            // Console.WriteLine(5 < 10 && 5 > 10);
            // Console.WriteLine(5 < 10 || 5 > 10);
            // // Console.WriteLine(myInt.Equals(mySecondInt));

            // Console.WriteLine(myInt.Equals(mySecondInt / 2));
            // // Console.WriteLine(" ");

            // Console.WriteLine(myInt == mySecondInt);
            // Console.WriteLine(myInt == mySecondInt/2);
            // Console.WriteLine(myInt != mySecondInt);
            // Console.WriteLine(myInt != mySecondInt/2);
            // Console.WriteLine(" ");

            // Console.WriteLine(myInt >= mySecondInt);
            // Console.WriteLine(myInt <= mySecondInt/2);
            // Console.WriteLine(myInt < mySecondInt);
            // Console.WriteLine(myInt > mySecondInt/2);

            // myInt++;            
            // Console.WriteLine(myInt);

            // myInt+=7;
            // Console.WriteLine(myInt);

            // myInt-=8;
            // Console.WriteLine(myInt);
            // Console.WriteLine("");

            // // Basoc Mathematics Operations 
            // Console.WriteLine("Basic Maths Operations");
            // Console.WriteLine(myInt - mySecondInt);
            // Console.WriteLine(myInt / mySecondInt);
            // Console.WriteLine(myInt + mySecondInt);
            // Console.WriteLine(myInt * mySecondInt);
            // Console.WriteLine("");

            // //In C# for operations PEMDAS = Parenthesis, Exponentials, Division,Multiplication, Addition and Substraction in that order
            // Console.WriteLine("PEMDAS");
            // Console.WriteLine(5 + 5 * 5);

            // Console.WriteLine("Power and SQuare Roots");
            // //Raise to power
            // Console.WriteLine(Math.Pow(5, 2));

            // //SquareRoot
            // Console.WriteLine(Math.Sqrt(25, 2));

            //Using operators to change the value of string
            // string myString = "test";

            // Console.WriteLine(myString); 
            // Console.WriteLine(myString + " and Second part.");

            // //Split a string by outputing a string array is used to divide a string into parts
            // string[] myStringArr = myString.Split(' ');
            // Console.WriteLine(myStringArr[0]);
            // Console.WriteLine(myStringArr[1]);
            
            // Console.WriteLine(" ");

            // int myFirstValue = 7;
            // int mySecondValue = 5;
            // //Write Your Code Here
            // Console.WriteLine(myFirstValue + mySecondValue);
            // Console.WriteLine(mySecondValue - myFirstValue);
            // Console.WriteLine(myFirstValue * mySecondValue);
            // Console.WriteLine(myFirstValue > mySecondValue);

            //If statement

            

        }
    }
}

// public class Exercise
// {
//     public void RunExercise()
//     {
//         // Create dictionary
//         Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>();

//         // Set prices
//         itemPrices["cheese"] = 5.99m;
//         itemPrices["carrots"] = 2.99m;

//         // Access and print prices
//         Console.WriteLine("Price of cheese: " + itemPrices["cheese"]);
//         Console.WriteLine("Price of carrots: " + itemPrices["carrots"]);
//     }
// }

