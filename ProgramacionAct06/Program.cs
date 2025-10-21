using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

    namespace checkInterval
{
    public static class Program
    {
        public static void Main()
        {
            const string Msg_input = "Enter a value to check if it's within the interval (5, 50):";
            const string Msg_ok = "Is within the interval (5, 50).";
            const string Msg_ko = "Is NOT within the interval (5, 50).";

            int number;

            Console.WriteLine(Msg_input);
            number = int.Parse(Console.ReadLine());

            if (number > 5 && number < 50)
            {
                Console.WriteLine(number + " " + Msg_ok);
            }
            else
            {
                Console.WriteLine(number + " " + Msg_ko); ;
            }
        }
    }
}
