namespace Marketplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.00;


            switch (day)
            {
                case "Weekday":
                    if (product == "Banana")
                        price = 2.50;
                    else if (product == "Apple")
                        price = 1.30;
                    else if (product == "Kiwi")
                        price = 2.20;

                    break;
                case "Weekend":
                    if (product == "Banana")
                        price = 2.70;
                    else if (product == "Apple")
                        price = 1.60;
                    else if (product == "Kiwi")
                        price = 3.00;

                    break;


            }
            Console.WriteLine(price);
        }
    }
}