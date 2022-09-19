namespace Day19Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number\n1.First Name Regex\n2.valid Last Name\n3.valid email");
            int obj=Convert.ToInt32(Console.ReadLine());    

            switch(obj)
            {
                case 1:
                    FirstNameRegex.ValidateFirstName();
                    break;
                case 2: 
                    LastNameregex.ValidateLastName();
                    break;
                case 3:
                    EmailRegex.ValidarEmail();
                    break;
                    
            }
           
        }
    }
}