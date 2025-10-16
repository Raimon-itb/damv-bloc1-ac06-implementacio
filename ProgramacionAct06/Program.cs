using System;

    namespace sumaEnters
{
    public static class Program
    {
        public static void Main()
        {
            const string Msg_input1 = "Enter the first integer: ";
            const string Msg_input2 = "Enter the second integer: ";
            const string Msg_result = "The sum is: ";

            int num1, num2, sum;
            Console.WriteLine(Msg_input1);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Msg_input2);
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;

            Console.WriteLine(Msg_result + sum);
        }
    }
}
