using System;

    namespace conversorKelvin
{
    public static class Program
    {
        public static void Main()
        {
            const string Msg_input = "Enter temperature in Clesius: ";
            const string Msg_result = "Temperature in Kelvin is: ";

            double celsius, kelvin;
            Console.WriteLine(Msg_input);
            celsius = Convert.ToDouble(Console.ReadLine());
      
            kelvin = celsius + 273.15;

            Console.WriteLine(Msg_result + kelvin);
        }
    }
}
