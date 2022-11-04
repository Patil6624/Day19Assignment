using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Assingment
{
    public class SampleEmail
    {
        public static string REGEX_SAMPLEMAILID = "[a-zA-Z0-9_\\-\\.]+[@][a-z]+[\\.][a-z]{2,3}";
        public static string REGEX_SAMPLEMAILID1 = "[a-zA-Z0-9_\\-\\.]+[@][a-z]+[\\.][a-z]{2,3}[\\.][a-z]{2,3}";
        //this function is use for Mail ID validate
        public bool validatemail(string userdata)
        {

            return Regex.IsMatch(userdata, REGEX_SAMPLEMAILID);

        }
    }
}