using System;

    namespace areaRectangle
{
    public static class Program
    {
        public static void Main()
        {
            const string Msg_input_width = "Enter the width of the rectangle: ";
            const string Msg_input_height = "Enter the height of the rectangle: ";
            const string Msg_result = "The area of the rectangle is: ";

            double width, height, area;
            Console.WriteLine(Msg_input_width);
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Msg_input_height);
            height = Convert.ToDouble(Console.ReadLine());

            area = width * height;

            Console.WriteLine(Msg_result + area);
        }
    }
}
