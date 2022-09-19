namespace Day19Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number\n1.First Name Regex");
            int obj=Convert.ToInt32(Console.ReadLine());    

            switch(obj)
            {
                case 1:
                    FirstNameRegex.ValidateFirstName();
                    break;
            }
           
        }
    }
}