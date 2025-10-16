using System;

    namespace dollarConverter
{
    public static class Program
    {
        public static void Main()
        {
            const double exchange_rate = 1.12;
            const string Msg_input = "Enter the amount of euros: ";
            const string Msg_result = "Amount in dollars: ";

            double euros, dollars;
            Console.WriteLine(Msg_input);
            euros = Convert.ToDouble(Console.ReadLine());

            dollars = euros * exchange_rate;

            Console.WriteLine(Msg_result + dollars);
        }
    }
}
