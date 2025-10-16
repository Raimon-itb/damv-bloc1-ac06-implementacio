using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

    namespace calculMitjana
{
    public static class Program
    {
        public static void Main()
        {
            const string Msg_input1 = "Enter first number: ";
            const string Msg_input2 = "Enter second number: ";
            const string Msg_input3 = "Enter third number: ";
            const string Msg_result = "The avarage is: ";

            double num1, num2, num3, avarage;
            Console.WriteLine(Msg_input1);
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Msg_input2);
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Msg_input3);
            num3 = Convert.ToDouble(Console.ReadLine());

            avarage = (num1 + num2 + num3) / 3;

            Console.WriteLine(Msg_result + avarage);
        }
    }
}
