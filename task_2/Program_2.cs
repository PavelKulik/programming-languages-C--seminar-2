internal class Program
{
    private static void Main(string[] args)
    {
        bool checkNumber(int date)
        {
            if (date > 99 && date < 1000) return true;
            else return false;
        }       

        int findThirdNumber(int date)
        {
            while (!checkNumber(date))
            {
                date = date / 10;
            }
            return date % 10;
        }

        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);
        
        Console.Write(number + " -> ");
        if (number < 100) Console.WriteLine("третьей цифры нет");
        else
        {
            int result = findThirdNumber(number);
            Console.WriteLine(result);
        }
        
    }
}