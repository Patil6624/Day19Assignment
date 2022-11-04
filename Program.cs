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

            Console.WriteLine("Enter Last Name");
            Console.WriteLine("NOTE:- Last name starts with Cap and has minimum 3 characters");
            //program for last name
            string userlastname = Console.ReadLine();

            value = userRegistration.validatelastname(userlastname);

            if (value)
            {
                Console.WriteLine("Given Last Name Accepted");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Last Name");
            }
            //program for email
            Console.WriteLine("Enter Mail ID");
            Console.WriteLine("NOTE:- E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl&co) and 2 optional (xyz & in) with\r\nprecise @ and . positions");

            string usermail = Console.ReadLine();

            value = userRegistration.validatemail(usermail);

            if (value)
            {
                Console.WriteLine("Given Mail ID  Accepted");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Mail ID");
            }

        }
    }
}
