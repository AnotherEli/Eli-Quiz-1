using System;
using System.Collections.Generic;
using System.Text;

namespace Professor_Class_Problem
{
    /* 
        * Assume that you've been asked to write a series 
        * of programs for a community college. One of the 
        * "components" in the college's system is a 
        * Professor. 
        * 
        * A Professor has an Lnumber, a first name, a 
        * last name and a department.
        * 
        * Design a class that represents a Professor. 
        * Document your class by creating a class diagram 
        * in Visio or Visual Studio or by listing the name 
        * of the class, the attributes or characteristics 
        * of the class and the methods of behaviors of the 
        * class. Don't forget things like getters and 
        * setters (and reasonable error handling in at 
        * least one of the setters) or properties, 
        * constructors and ToString.
        * 
        * Implement the class in C#. 
        * Test the class in a C# console application.
    */
    class Professor
    {
        //instance variables
        private string lNumber;
        private string firstName;
        private string lastName;
        private string department;

        //constructors
        public Professor()
        {
            lNumber = "L00000000";
            firstName = "FIRST NAME";
            lastName = "LAST NAME";
            department = "DEPARTMENT";
        }

        public Professor(string lNum, string fn, string ln, string d)
        {

            lNumber = lNum;
            firstName = fn;
            lastName = ln;
            department = d;
        }

        //properties
        public string LNumber
        {
            get
            {
                return lNumber;
            }
            set
            {
                if (value[0].Equals('l') || value[0].Equals('L'))
                    lNumber = value;
                else
                {
                    Console.WriteLine("The first character of an L number must be L");
                    lNumber = "L00000000";
                    throw new ArgumentException("The first character of an L number must be L");
                }

            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public override string ToString()
        {
            return "L-Number: " + lNumber + "\nFirst Name: " + firstName + "\nLast Name: " + lastName + "\nDepartment Name: " + department;
        }
    }
}
