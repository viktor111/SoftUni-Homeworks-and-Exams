using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidUsernames
{
    public class Program
    {
        public static void Main()
        {
            List<string> listOfUsernames = Console.ReadLine()
                .Split(", ")
                .ToList();

            for (int i = 0; i < listOfUsernames.Count; i++)
            {
                string username = listOfUsernames[i];
                bool isValid = false;

                if (username.Length >= 3 && username.Length <= 16)
                {
                    for (int j = 0; j < username.Length; j++)
                    {
                        char charFromUsername = username[j]; 

                        if (char.IsLetterOrDigit(charFromUsername) ||
                            charFromUsername == '-' ||
                            charFromUsername == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
