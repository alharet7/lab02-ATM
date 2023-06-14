using System.Data;

namespace ATM
{
    public class Program
    {
        static public decimal Balance;
        static void Main(string[] args)
        {
            UserInterFace();
        }
        public static decimal ViewBalance()
        {
            if (Balance <= 0)
            {
                Console.WriteLine("You'r amount balance is empty");
                return 0;
            }
            return Balance;
        }
        public static decimal WithDraw(decimal draw)
        {
            if (draw <= 0)
            {
                draw = Math.Abs(draw);
            }
            else if (draw > Balance)
            {
                Console.WriteLine("The amount to be withdrawn is greater than the available balance!");
                return 0;
            }
                Balance -= draw;
                return Balance;  
        }
        public static decimal Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                amount = Math.Abs(amount);
            }
            return Balance += amount;
        }
        public static void UserInterFace() 
        {
            Console.WriteLine("Wellcome! How we can hellp you?\n");
            bool inetrAction = true;
            while (inetrAction)
            {
                Console.WriteLine("Please enter the number of the transaction\n1: View Balance 2: withdrawal 3: Deposit 4: Exit ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine($"Your Balnce is {ViewBalance()}");   
                }
                if (input ==2 ) 
                {
                    Console.WriteLine("Enter the amount to be withdrawn");
                    decimal draw = Convert.ToDecimal(Console.ReadLine());
                    WithDraw(draw);
                    Console.WriteLine($"Your Balance is {ViewBalance()}");
                }
                if (input == 3)
                {
                    Console.WriteLine("Enter the amount to Deposit");
                    decimal deposit = Convert.ToDecimal(Console.ReadLine());
                    Deposit(deposit);
                    Console.WriteLine($"Your Balance is {ViewBalance()}");
                }
                if (input == 4)
                {
                    inetrAction = false;
                }
            }
        }
    }
}