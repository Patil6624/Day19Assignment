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

            Console.WriteLine("Enter Mobile Number");
            Console.WriteLine("NOTE:- Mobile Format - E.g. 91 9919819801 - Country code follow by space and 10 digit number");

            string usermobile = Console.ReadLine();

            value = userRegistration.validatemobile(usermobile);

            if (value)
            {
                Console.WriteLine("Given Mobile Number  Accepted");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Mobile Number");
            }

            Console.WriteLine("Enter Password");
            Console.WriteLine("NOTE:- Password minimum 8 Characters ");

            string userpassword = Console.ReadLine();

            value = userRegistration.validatepassword(userpassword);

            if (value)
            {
                Console.WriteLine("Given Password  Accepted");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Password");
            }

            Console.WriteLine("\n");
            Console.WriteLine("______________UC9____________________");
            Console.WriteLine("SAMPLE EMAIL ID TEST");
            SampleEmail sampleEmail = new SampleEmail();
            Console.WriteLine("Enter Mail ID");
            Console.WriteLine("NOTE:- E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl&co) and 2 optional (xyz & in) with\r\nprecise @ and . positions");

            string usermail1 = Console.ReadLine();

            value = sampleEmail.validatemail(usermail1);

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