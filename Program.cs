using System;

namespace Datatypes
{
    //Lab 2 Assignment
    class Program
    {
        static void Main(string[] args)
        {
            //Declare 10 variables with 10 different data types
            string name = "Prince";  //string datatype
            int year = 1998;  //int datatype
            double height = 5.11; //double datatype
            short students = 1700; //short datatype
            char Grade = 'A';  //character datatype
            bool value = true;  //boolean datatype
            long phoneNo = 2349050789298;  //long datatype
            float bnb = 444.96f;  //float datatype
            decimal ripple =0.827142m; //decimal datatype
            byte backend = 200;  //byte datatype

            //Type Conversions(Implicit / Explicit)
            char letter = 'A';
            int digit = letter;         //Implicit type conversion(small rang to big range)
            double pi= 3.141592653589793238f;
            float piNum = (float)pi;     //Explicit type conversion(big range to small range)

            Console.WriteLine("Hi! my name is "+ name + ", I was born in  " +year+ ", I'm " + height+"ft tall and my tel is "+phoneNo);
            Console.WriteLine("We're up to "+students + " at WH-school, we're "+ backend+" in Backend-class and we're " +Grade+ "+ students.");
            Console.WriteLine("The value of BNB is "+ bnb +" and the value of Ripple is $"+ripple +" and these values are "+value);

            Console.WriteLine("Do you know that the letter "+letter+" is equal to "+digit+" in a computer system.");
            Console.WriteLine("The value of pi is more than "+pi+" but it is generally used as "+ piNum+" or less.");
        }
    }
}
