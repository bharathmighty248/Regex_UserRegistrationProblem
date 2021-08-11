using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Problem\n" +
                "Please Fill Below Details..");
            Validation validation = new Validation();
            Console.Write("Enter FirstName: ");
            string firstName = Console.ReadLine();
            bool fNresult = validation.ValidateFirstName(firstName);
            validation.Result(fNresult);

            Console.Write("Enter LastName: ");
            string lastName = Console.ReadLine();
            bool lNresult = validation.ValidateLastName(lastName);
            validation.Result(lNresult);

            Console.Write("Enter MobileNum: ");
            string mobileNum = Console.ReadLine();
            bool mNresult = validation.ValidateMobileNum(mobileNum);
            validation.Result(mNresult);

            Console.Write("Create Password: ");
            string password = Console.ReadLine();
            bool presult = validation.ValidatePassword(password);
            validation.Result(presult);
        }
    }
}
