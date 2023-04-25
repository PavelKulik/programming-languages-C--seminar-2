internal partial class Program
{
    private static void Main(string[] args)
    {
        bool chechDayWeek(int dateDay)
        {
            if (dateDay > 0 && dateDay < 8) return true;
            else return false; 
        }

        bool chechDayWeekend(int weekendDay)
        {
            if (weekendDay == 6 || weekendDay == 7) return true;
            else return false;
        }

        Console.Write("Введите день недели: ");
        int day = int.Parse(Console.ReadLine()!);

        if (!chechDayWeek(day)) Console.WriteLine("Число не является днем недели!");
        else
        {
            Console.Write(day + " -> ");
            if (chechDayWeekend(day)) Console.WriteLine("да");
            else Console.WriteLine("нет");
        }
    }
}