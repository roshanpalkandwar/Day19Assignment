namespace Day19Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number\n1.First Name Regex\n2.valid Last Name\n3.valid email\n4.valid Mobile Number\n5.Valide Password\n6.Password rule 2\n7.Password Rule 3\n8.Password Rule 4\n9.Email Sample");
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
                case 4:
                    MobileNUmber.ValidateMobileNumber();
                    break;
                case 5:
                    PassWordRegex.ValidatePassWord();
                    break;
                case 6:
                    PassWord2.ValidatePassWord2();
                    break;
                case 7:
                    PassWord3.ValidatePassWord3();
                    break;
                case 8:
                    Password4.ValidatePassWord4();
                    break;
                case 9:
                    EmailSample.emailSample();
                    break;
            }
           
        }
    }
}