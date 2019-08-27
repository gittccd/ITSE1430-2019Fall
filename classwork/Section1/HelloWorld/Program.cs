/*
 * ITSE 1430
 * Lab 1
 * Me 
 */
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( /*string[] args*/ )
        {
            //TODO: Move this
            string name = "";

            //string if = "";

            //Definitely assigned
            //name = "Bob";
            string name2 = Console.ReadLine ();
            //name2 = Console.ReadLine ();

            name2 = name = "Sue";
            Console.WriteLine (name2);
            Console.WriteLine ("Hello World!");

            //Another block
            //Yet another block
            
            int hours = 8;
            double payRate = 15.25;

            double totalPay = payRate * hours;

            string fullName = "Fred" + " " + "Jones";

            DemoArithmetic ();
            DemoRelational ();
            DemoLogical ();
            DemoConditional ();
        }

        static void DemoArithmetic ()
        {
            int hours = 8;
            double payRate = 15.25;

            double totalPay = hours * payRate;

            double taxes = totalPay * 0.33;

            //Combination operators work
            hours += 8;

            totalPay = hours * payRate;
            double newTaxes = totalPay * 0.66;
        }

        static void DemoRelational ()
        {
            int grade = 75;
            int passingGrade = 60;

            bool isGreater = grade > passingGrade;
            bool isGreaterThanOrEqual = grade >= passingGrade;
            bool isLessThan = grade < passingGrade;
            bool isLessThanOrEqual = grade <= passingGrade;
            bool isEqual = grade == passingGrade;
            bool isNotEqual = grade != passingGrade;
        }

        static void DemoLogical ()
        {
            bool value1 = true;
            bool value2 = false;

            //Both left and right must be true
            bool logicalAnd = value1 && value2;

            //Either left or right must be true
            bool logicalOr = value1 || value2;

            //Negates the value
            bool logicalNot = !value1;
        }

        static void DemoConditional ()
        {
            int grade = 75;

            // C ? T : F
            // Evaluate C, if true then T is the value of the expression
            //otherwise F is
            bool isPassing = grade > 60 ? true : false;

            //Equivalent to what an if statement could do if it were an expression
            if (grade > 60)
                isPassing = true;
            else
                isPassing = false;
        }
    }
}
