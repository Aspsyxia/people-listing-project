using System;
using System.Collections.Generic;

namespace PeopleListing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> personsData = new Dictionary<string, string>();
            FileOperations.SaveToFile(personsData);

            while (true)
            {
                string[] inputLine = Console.ReadLine().Split();
                Person newPerson = new Person(inputLine[0], inputLine[1], inputLine[2], inputLine[3]);
                string dane = newPerson.ToString();

                if (!CheckPESEL.ValidCheck(newPerson.PESEL))
                {
                    Console.WriteLine("Given PESEL is not correct - check if it is 11 signs long and if validation number is correct");
                    continue;
                }

                if (!CheckPESEL.CorrectSex(newPerson.PESEL, newPerson.Name))
                {
                    Console.WriteLine("Given PESEL does not match person's sex");
                    continue;
                }

                if (!personsData.ContainsKey(newPerson.PESEL))
                {
                    Console.WriteLine("Person succesfully added");
                    personsData.Add(newPerson.PESEL, dane);
                    FileOperations.SaveToFile(personsData);
                }

                else
                {
                    Console.WriteLine("Person succesfully replaced");
                    personsData[newPerson.PESEL] = dane;
                    FileOperations.SaveToFile(personsData);
                }
            }
        }
    }
}
