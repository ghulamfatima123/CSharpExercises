using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask.PracticePrograms
{
    internal class PasswordChecker
    {
        int score = 0;
        int minLength = 7;
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        string digits = "0123456789";
        string specialChars = "$%^&*()!@";

        public void CheckPasswordStrength()
        {
            
            Console.WriteLine("enter the password");
            string password = Console.ReadLine();

            if (password.Length >= minLength)
            {
                score++;
            }
            if (password.Any(c=>lowercase.Contains(c))) {
                score++;
            }
            if (password.Any(c=>uppercase.Contains(c))) {
                score++;
            }

            if (password.Any(c=>digits.Contains(c))) {
                score++;
            }
            if (password.Any(c=>specialChars.Contains(c))) {
                score++;
            }

           
            switch (score)
            {
                case 5:
                case  4:
                    Console.WriteLine("Password is very strong");
                    break;
                case 3:
                    Console.WriteLine("Password is strong");
                    break;
                case 2:
                    Console.WriteLine("Password is medium");
                    break;
                case 1:
                    Console.WriteLine("Password is weak");
                    break;
                default:
                    Console.WriteLine("password doesnt meet any criteria");
                    break;



            }
        }
       
        
        


    }
}
