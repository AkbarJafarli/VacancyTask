using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace VacancyTask
{
    internal class Program
    {





        public static bool check_name(string input)
        {
            if (input.Length < 2 || input.Length > 20)
            {
                return false;
            }

            if (!char.IsUpper(input[0]))
            {
                return false;
            }

            if (!input.All(char.IsLetter))
            {
                return false;
            }

            return true;
        }



        public static bool check_surname(string surname)
        {
            if (surname.Length < 2 || surname.Length > 35)
            {
                return false;
            }

            if (!char.IsUpper(surname[0]))
            {
                return false;
            }

            if (!surname.All(char.IsLetter))
            {
                return false;
            }

            return true;
        }
   

        public static void Main(string[] args)
{

    string name, surname, fatherName, FIN, phoneNumber, profession;
    int choice, age, salary;
    while (true)
    {
        bool hasNonLetter = false;
        bool hasNonLetter2 = false;
        bool hasNonLetter3 = false;
        bool isUpper = false;
        bool isUpper2 = false;
        bool isUpper3 = false;
        bool isValid = false;
        bool isPref = false;
        Console.WriteLine("|Welcome to the job posting app:|");
        Console.WriteLine("|-------------------------------|");
        Console.WriteLine();
        Console.WriteLine("Please fill out the questionnaire.");
        Console.WriteLine("1.Name");
        Console.WriteLine("2.Surname");
        Console.WriteLine("3.Father name");
        Console.WriteLine("4.Age");
        Console.WriteLine("5.FIN");
        Console.WriteLine("6.Phone Number");
        Console.WriteLine("7.Profession");
        Console.WriteLine("8.Salary");
        Console.WriteLine();
        Console.Write("Select: ");
        choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            while (true)
            {
                Console.Write("Enter the name: ");
                name = Console.ReadLine();

                bool a = check_name(name);

                if (a)
                {
                    Console.WriteLine("Name is acceptable.");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                }
                else
                {
                    Console.WriteLine("Ad yanlisdir.");
                }
            }
        }

        else if (choice == 2)
        {
            while (true)
            {
                Console.Write("Enter the surname: ");
                surname = Console.ReadLine();

                bool a = check_surname(surname);

                if (a)
                {
                    Console.WriteLine("Surname is acceptable.");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                }
                else
                {
                    Console.WriteLine("Soyad yanlisdir.");
                }
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine("Enter the father name:");
            fatherName = Console.ReadLine();
            while (true)
            {
                if (fatherName.Length < 2 || fatherName.Length > 20)
                {
                    Console.WriteLine("Father name length must be between 2 and 20");
                }
                else
                {
                    break;
                }
            }

            for (int idx = 0; idx < fatherName.Length; idx++)
            {
                char c = fatherName[idx];
                if (!char.IsLetter(c))
                {
                    hasNonLetter3 = true;
                    break;
                }
            }
            if (hasNonLetter3)
            {
                Console.WriteLine("Enter the correct letter");
            }
            for (int idx = 0; idx < fatherName.Length; idx++)
            {
                if (char.IsUpper(fatherName[0]))
                {
                    isUpper3 = true;
                }
            }
            if (!isUpper3)
            {
                Console.WriteLine("The first letter must be capitalized");
            }
            Console.WriteLine("==================");
            Console.WriteLine("Go to the survey:");
            Console.ReadLine();
            Console.Clear();
        }
        else if (choice == 4)
        {
            while (true)
            {
                Console.WriteLine("Enter the age");
                age = int.Parse(Console.ReadLine());
                if (age < 18 || age > 65)
                {
                    Console.WriteLine("The age range is between 18 and 65");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("==================");
            Console.WriteLine("Go to the survey:");
            Console.ReadLine();
            Console.Clear();
        }
        else if (choice == 5)
        {
            while (true)
            {
                Console.WriteLine("Enter the FIN code:");
                FIN = Console.ReadLine();
                if (FIN.Length == 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Code length should be 7");
                }
            }
            for (int idx2 = 0; idx2 < FIN.Length; idx2++)
            {
                char x = FIN[idx2];
                if ((char.IsUpper(x) || char.IsDigit(x)))
                {
                    isValid = true;
                }
            }
            if (!isValid)
            {
                Console.WriteLine("The code must contain only capital letters and numbers");
            }
            Console.WriteLine("==================");
            Console.WriteLine("Go to the survey:");
            Console.ReadLine();
            Console.Clear();

        }
        else if (choice == 6)
        {
            while (true)
            {
                Console.WriteLine("Enter the phone number:");
                phoneNumber = Console.ReadLine();



                if (phoneNumber.Length == 13)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Number length must be equal to 13");
                }
            }
            for (int idx3 = 0; idx3 < phoneNumber.Length - 9; idx3++)
            {
                string prefix = "+994";
                int PxIdx = 0;
                if (phoneNumber[idx3] == prefix[PxIdx])
                {
                    isPref = true;
                }
                PxIdx++;
            }
            if (!isPref)
            {
                Console.WriteLine("+994 le baslamalidi");
            }

        }
        else if (choice == 7)
        {
            while (true)
            {
                Console.WriteLine("Enter the profession");
                profession = Console.ReadLine();
                if (profession == "HR" || profession == "Audit" || profession == "Engineer")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Only HR,Audit,Engineer vacancy available");
                }
            }
        }
        else if (choice == 8)
        {
            while (true)
            {
                Console.WriteLine("Enter the salary");
                salary = int.Parse(Console.ReadLine());
                if (salary >= 1500 && salary <= 5000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Salary can be in the range of 1500-5000");
                }
            }
        }




    }



























}

    }



}