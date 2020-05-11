using System;

namespace Professor_Class_Problem
{
    class Program
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //constructors
            Console.WriteLine("\n This professor should be the default. \n");
            Professor defaultProfessor = new Professor();
            Console.WriteLine(defaultProfessor.ToString());

            Console.WriteLine("\n This professor should be overloaded. \n");
            Professor realProfessor = new Professor("L009800988", "Jessica", "Doctoratehaver", "Studies of Graduates");
            Console.WriteLine(realProfessor.ToString());

            //properties
            realProfessor.LNumber = "L00444444";
            realProfessor.FirstName = "Jess";
            realProfessor.LastName = "Doctor";
            realProfessor.Department = "Graduate Studies";

            
            Console.WriteLine("Testing setters for Jessica" + realProfessor.ToString());

            Console.WriteLine("\n The fake professor should throw an exception. \n");
            Professor fakeProfessor = new Professor();

            fakeProfessor.LastName = " PROFESSOR ";
            fakeProfessor.FirstName = "FAKE";
            fakeProfessor.Department = "NOT DEPARTMENT";
            fakeProfessor.LNumber = "123456789";

            Console.WriteLine(fakeProfessor.ToString());



        }
    }
}
