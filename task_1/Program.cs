internal class Program
{

    private static void Main(string[] args)
    {
        bool checkNumber(int date)
        {
            if (date > 99 && date < 1000) return true;
            else return false;
        }

        int secondDate(int date) => date / 10 % 10;

        Console.Write("Введите трёхзначное число: ");
        int number = int.Parse(Console.ReadLine()!);

        if (!checkNumber(number)) Console.WriteLine("Введино не трёхзначное число!");
        else
        {
            int result = secondDate(number);
            Console.WriteLine(number + " -> " + result);
        }
    }
}