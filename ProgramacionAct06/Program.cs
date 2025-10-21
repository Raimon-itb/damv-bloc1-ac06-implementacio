using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

    namespace isNaturalNumber
{
    public static class Program
    {
        public static void Main()
        {
            const string Msg_input = "Enter a value to check if it's a natural: ";
            const string Msg_ok = "Is a natural number.";
            const string Msg_ko = "Is NOT a natural number.";

            int value;
            bool isNatural;

            Console.WriteLine(Msg_input);
            value = Convert.ToInt32(Console.ReadLine());

            if (value >= 0)
            {
                isNatural = true;
            }
            else
            {
                isNatural = false;
            }

            if (isNatural )
            {
                Console.WriteLine(Msg_ok);
            }
            else
            {
                Console.WriteLine(Msg_ko);
            }
        }
    }
}
