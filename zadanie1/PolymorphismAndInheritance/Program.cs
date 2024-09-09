using System;

public class CustomConverter
{
    public static bool TryConvert(string value, out int result)
    {
        return int.TryParse(value, out result);
    }
    public static bool TryConvert(string value, out double result)
    {
        return double.TryParse(value, out result);
    }
    public static bool TryConvert(string value, out bool result)
    {
        return bool.TryParse(value, out result);
    }
    public static bool TryConvert(string value, out DateTime result)
    {
        return DateTime.TryParse(value, out result);
    }
    public static bool TryConvert(string value, out decimal result)
    {
        return decimal.TryParse(value, out result);
    }
}
class Program
{
    static void Main()
    {
        string input = "312";
        if (CustomConverter.TryConvert(input, out int intResult))
        {
            Console.WriteLine($"int result: {intResult}");
        }
        else
        {
            Console.WriteLine("dada");
        }
        if (CustomConverter.TryConvert(input, out double doubleResult))
        {
            Console.WriteLine($"double result: {doubleResult}");
        }
        else
        {
            Console.WriteLine("failed");
        }
        string boolInput = "True";
        if (CustomConverter.TryConvert(boolInput, out bool boolResult))
        {
            Console.WriteLine($"bool result: {boolResult}");
        }
        else
        {
            Console.WriteLine("failed.");
        }
        string dateInput = "1945-06-22";
        if (CustomConverter.TryConvert(dateInput, out DateTime dateResult))
        {
            Console.WriteLine($"DateTime result: {dateResult}");
        }
        else
        {
            Console.WriteLine("failed.");
        }
        if (CustomConverter.TryConvert(input, out decimal decimalResult))
        {
            Console.WriteLine($"decimal result: {decimalResult}");
        }
        else
        {
            Console.WriteLine("failed.");
        }
    }
}