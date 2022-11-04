namespace Day19_Assingment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome TO Day 19 assingment Problem");
            Console.WriteLine("Hello User please Enter the First Name");
            Console.WriteLine(" NOTE:- First name starts with Cap and haS nminimum 3 characters");

            string userdata = Console.ReadLine();
            UserRegistration userRegistration = new UserRegistration();
            bool value = userRegistration.validatename(userdata);


            if (value)
            {
                Console.WriteLine("Given Name Accepted");

            }
            else
            {
                Console.WriteLine("Please Enter Valid Name");
            }
        }
    }
}
