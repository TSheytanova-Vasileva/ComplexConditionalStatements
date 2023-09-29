namespace BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point = int.Parse(Console.ReadLine());
             double totalpoint = 0;

            if (point >= 0 && point <= 3)
                totalpoint = point + 5;
            else if (point >= 4 && point <= 6)
                totalpoint = point + 15;
            else if (point >= 7 && point <= 9)
                totalpoint = point + 20;
            Console.WriteLine(totalpoint);
        }
    }
}