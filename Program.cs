namespace leapyearday5
{
    public static class program
    {
        public static void Main()
        {
            int check_year;
           
            Console.Write("Check whether a given year is leap year or not:\n");
            
        
            Console.Write("Input an year : ");
            check_year = Convert.ToInt32(Console.ReadLine());

            if ((check_year % 400) == 0)
                Console.WriteLine("{0} is a leap year", check_year);
            else if ((check_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year", check_year);
            else if ((check_year % 4) == 0)
                Console.WriteLine("{0} is a leap year", check_year);
            else
                Console.WriteLine("{0} is not a leap year", check_year);


        }
    }
}