namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();   
            
            int rows = int.Parse(Console.ReadLine());
            int seat = int.Parse(Console.ReadLine());
            double price =0; 
            double totalseat = 0; 
            double totalprice = 0; 

            switch (type)
            {
                case "Premiere":
                    price = 12;
                    
                    break;
                case "Normal":
                    price = 7.5;
                    
                    break;
                case "Discount":
                    price = 5;
                    break;

                    
                    

            }
            totalseat = rows * seat;
            totalprice = totalseat * price;
            Console.WriteLine(totalprice);
        }
    }
}