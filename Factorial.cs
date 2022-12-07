namespace factorial
{

    class Program
    {
        static int factorial(int n)
        {
            if (n <= 1)
                return 1;
            return n* factorial(n-1);
        }

        static void Main (string[] args)
        {
            int number, result;
            //User input
            Console.WriteLine("Please enter a non negative number");
            //Convert user input 
            number = Convert.ToInt32(Console.ReadLine());
            //calling the factorial function 
            result = factorial(number);
            Console.WriteLine("{0}!= {1}" ,number, result);

        }
    }
};

