using System;
    class CompanyInfo
    {
        //Write a program that reads the information about a company and its manager and prints them on the console.
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name of the company:");
            string CompanyName = Console.ReadLine();
            Console.WriteLine("Please enter the adress of the company:");
            string CompanyAdress = Console.ReadLine();
            Console.WriteLine("Please enter the phone number of the company:");
            int CompanyPhone =int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the fax number of the company:");
            int CompanyFax =int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the website of the company:");
            string CompanyWebsite = Console.ReadLine();
            Console.WriteLine("Please enter the first name of the manager of the company:");
            string CompanyManagerFirstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name of the manager of the company:");
            string CompanyManagerLastName = Console.ReadLine();
            Console.WriteLine("Please enter the age of the manager of the company:");
            int CompanyManagerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the phone number of the company:");
            int CompanyManagerNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The company's name is {0}, the adress is {1}, the phone number is {2}, the fax number is {3} and the website is {4}.",CompanyName, CompanyAdress,CompanyPhone,CompanyFax,CompanyWebsite); 
            Console.WriteLine("The manager of the company is {0} {1}. They are {2} years old and their phone number is {3}",CompanyManagerFirstName,CompanyManagerLastName,CompanyManagerAge,CompanyManagerNumber);
        }
    }

