using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration
{
    internal class StudentInfoClass
    {
        //make 2 delegates from table
        // long for large integer

        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);


        public static DelegateNumber DelStudNo;
        public static DelegateNumber DelNumAge;
        public static DelegateNumber DelNumContactNo;

        public static DelegateText DelProgram;
        public static DelegateText DelLastName;
        public static DelegateText DelFirstName;
        public static DelegateText DelMiddleName;
        public static DelegateText DelAddress;

        public static long StudentNo = 0;
        public static long Age = 0;
        public static long ContactNo = 0;

        public static string Program = " ";
        public static string LastName = " ";
        public static string FirstName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";

        //=+ TAB

        public static long GetStudentNo() => StudentNo;
        public static long GetAge() => Age;
        public static long GetContactNo() => ContactNo;


        public static string GetProgram() => Program;
        public static string GetLastName() => LastName;
        public static string GetFirstName() => FirstName;
        public static string GetMiddleName() => MiddleName;
        public static string GetAddress() => Address;




    }
}
