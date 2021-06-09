using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    class ToDoClass
    {
        public void ShowMeToDoText()
        {
            var textWrapper = new TextWrap();
            Console.WriteLine("Exercises ToDo still: ");
            var CFText = "ControlFlow2; \n" + 
                //"1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console. \n" +
                "2 - Write a program and continuously ask the user to enter a number or 'ok' to exit. Calculate the sum of all the previously entered numbers and display it on the console.\n" +
                "3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.\n" +
                "4 - Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display 'You won'; otherwise, display 'You lost'. (To make sure the program is behaving correctly, you can display the secret number on the console first.)\n"+
                "5 - Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters '5, 3, 8, 1, 4', the program should display 8.";

            var arraysText = "ArrayAndLists; \n" +
                "1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.\n" +
                "If no one likes your post, it doesn't display anything.\n" +
                "If only one person likes your post, it displays: [Friend's Name] likes your post.\n" +
                "If two people like your post, it displays:[Friend 1] and[Friend 2] like your post.\n" +
                "If more than two people like your post, it displays:[Friend 1], [Friend 2] and[Number of Other People] others like your post.\n" +
                "Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name). Depending on the number of names provided, display a message based on the above pattern.\n" +
                "2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.Display the reversed name on the console.\n" +
                "3 - Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re -try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.\n" +
                "4 - Write a program and ask the user to continuously enter a number or type 'Quit' to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.\n" +
                "5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display 'Invalid List' and ask the user to re-try; otherwise, display the 3 smallest numbers in the list. \n";

            var workingWithtext = "WorkingWithText; \n" +
                "1 - Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is '5 - 6 - 7 - 8 - 9' or '20 - 19 - 18 - 17 - 16', display a message: 'Consecutive'; otherwise, display 'Not Consecutive'.\n" +
                "2 - Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display 'Duplicate' on the console.\n" +
                "3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display 'Ok'; otherwise, display 'Invalid Time'. If the user doesn't provide any values, consider it as invalid time.\n" +
                "4 - Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: 'number of students', display 'NumberOfStudents'. Make sure that the program is not dependent on the input. So, if the user types 'NUMBER OF STUDENTS', the program should still display 'NumberOfStudents'.\n" +
                "5 - Write a program and ask the user to enter an English word. Count the number of vowels(a, e, o, u, i) in the word. So, if the user enters 'inadequate', the program should display 6 on the console.";

            var fileProcessing = "FileHandling: \n" +
                "1 - Write a program that reads a text file and displays the number of words. \n" +
                "2 - Write a program that reads a text file and displays the longest word in the file.";

            Console.WriteLine(textWrapper.WrapText(CFText));
            Console.WriteLine(textWrapper.WrapText(arraysText));
            Console.WriteLine(textWrapper.WrapText(workingWithtext));
            Console.WriteLine(textWrapper.WrapText(fileProcessing));
            
          

        }
    }
}
