using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation();
            Console.Write("Enter FirstName: ");
            string firstName = Console.ReadLine();
            bool FNresult = validation.ValidateFirstName(firstName);
            validation.Result(FNresult);
        }
    }
}
