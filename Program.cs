using System;
using System.Collections.Generic;

class Program
{
  static void Main (String[] args)
  {
    // list of students
    List<Dictionary<string, string>> students = new List<Dictionary<string, string>>();

    while (true) {

      // Dictionary for our student
      Dictionary<string, string> student = new Dictionary<string, string>();

    // Prompt user for student's identification information...
    // assign to dictionary
    Console.Write("Please enter the student's first name. ");
    string firstName = Console.ReadLine();
    student.Add("first name", firstName);

    Console.Write("Please enter the student's middle name. ");
    string middleName = Console.ReadLine();
    student.Add("middle name", middleName);

    Console.Write("Please enter the student's last name. ");
    string lastName = Console.ReadLine();
    student.Add("last name", lastName);

    // Prompt user for student's contact information...
    Console.Write("Please enter the student's address. ");
    string address = Console.ReadLine();
    student.Add("address", address);

    Console.Write("Please enter the student's email. ");
    string email = Console.ReadLine();
    student.Add("email", email);

    Console.Write("Please enter the student's phone number. ");
    string phoneNumber = Console.ReadLine();
    student.Add("phone number", phoneNumber);

    // Update output to read all of the values from the Dictionary instead
      foreach (KeyValuePair<string, string> pair in student) {
        Console.WriteLine("The student's " + pair.Key + " is " + pair.Value + ".");
      }


    // Ask if input was correct
      Console.Write("Is this information correct? (Y/n) ");
      string correctInfo = Console.ReadLine();

       if (correctInfo == "y" || correctInfo == "Y")
      {
        // add student to list and ask if they'd like to add another
        students.Add(student);
         Console.Write("Would you like to add another student? (Y/n) ");
         string addMore = Console.ReadLine();

         if (addMore.ToLower() == "y")
         {
           Console.WriteLine("Please enter the next student. ");
          continue;
         }
         // log all of the students
         int counter = 0;
         foreach (Dictionary<string, string> dict in students) {
           counter++;
           foreach (KeyValuePair<string, string> pair in dict) {
             Console.WriteLine("Student #" + counter.ToString() + "'s " + pair.Key + " is " + pair.Value + ".");
           }
         }

        
        break;
      }
      Console.WriteLine("Enter the correct value!");
      }
    }
  }

