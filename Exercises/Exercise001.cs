using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {   
            if (String.IsNullOrEmpty(word) || String.IsNullOrWhiteSpace(word))
            {
                return word;
            }
            else if (word.Length == 1)
            {
                return word.ToUpper();
            }
            else
            {
                return char.ToUpper(word[0]) + word.Substring(1);
            }
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            if (String.IsNullOrEmpty(firstName) || String.IsNullOrWhiteSpace(firstName) ||
                String.IsNullOrEmpty(lastName)  || String.IsNullOrWhiteSpace(lastName))
                
            {
                throw new NotImplementedException();
            }
            else 
            {
                return (firstName[0] + "." + lastName[0]);
            }     
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            if (originalPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            }
            else if (vatRate < 0)
            {
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            }
            else
            {
                return Math.Round((1 + vatRate/100) * originalPrice,2);
            }            
        }

        public string Reverse(string sentence)
        {
             if (String.IsNullOrEmpty(sentence) || String.IsNullOrWhiteSpace(sentence) || sentence.Length == 1)
             {
                 return sentence;
             }            
             else
             {
                 char[] array = sentence.ToCharArray();
                 Array.Reverse(array);
                 return new string(array);
             }
        }

        public int CountLinuxUsers(List<User> users)
        {
            if (users == null || users.Count == 0 )            
            {
                return 0;   
            }
            else 
            {
                int numberOfUsers = 0;                

                foreach (User user in users)
                {   
                    if (user.Type == "Linux")
                    {
                        numberOfUsers++;                       
                    }                     
                }
                return numberOfUsers;
            }            
        }
    }
}
