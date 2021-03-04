using System;
using System.Collections.Generic;

namespace JediTricks
{
    public class Program
    {
    
        public static void Main()
        {
            // Dictionary containing the persons used with assigment 1 and 2
            Dictionary<string, int> people = new Dictionary<string, int>();                      
            people.Add("Patrick Heesch", 26);                                                    // Adds the first person to the dictionary with the add function
            people.Add("Karl Lund", 64);
            Console.WriteLine(people["Patrick Heesch"]);                                         // Prints out the Value on the first index, by using a search criteria

            // Another Dictionary used for assignment 3 and 4
            Dictionary<string, bool> characters = new Dictionary<string, bool>()                 
            {
                {"Luke", true },                                                                 //Adds to the characters dictionary
                {"Han", false },                                                                 //Adds to the characters dictionary
                {"Chewbacca", false }                                                            //Adds to the characters dictionary
            };

            characters.Remove("Han");                                                            // Removes Han from the dictionary
            foreach (var hanRemoved in characters)                                               // Runs a foreach loop with a var type
            {
                Console.WriteLine("Name: " + hanRemoved.Key + ". Jedi? " + hanRemoved.Value.ToString());    //Prints out the contents of the characters Dictionary 
            }
            
            Console.ReadKey();
        }
    }

        
    
}
