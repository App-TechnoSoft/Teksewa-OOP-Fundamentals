using ABC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForFundamentals.Generics;
internal class PlayingWIthCollections
{
    // Arrays, Lists, Dictionaries

    public static void LearnArrays()
    {
        string[] empNames = new string[10];
        empNames[0] = "Bishnu";
        empNames[1] = "Bishnu";
        empNames[2] = "Bishnu";

        string[] names = ["Bishnu", "Bishnu2", "Ramesh"];
        byte[] evenNumbers = [2, 4, 6, 8, 10, 12, 14, 16, 18];

        int[,] mat2 = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[][] mat1 = [[2, 3, 4], [3, 4]]; // Jagged arrays

        // Create an array of numbers from 1 to 100
        // Fromt that collection, print the number to console if its multiple of 3 or 5
        int[] numbers = Enumerable.Range(1, 100).ToArray();
    }

    public void LearnLists()
    {
        List<string> names = ["Bishnu", "Bishnu2", "Ramesh"];
        names.Add("Ram");        

        List<(string Country, string Capital)> countries = new();
        countries.Add(("Nepal", "Kathmandu"));
        countries.Add(("India", "Dehli"));
        countries.Add(("China", "beijing"));

        List<Person> people = new();

        //Person person1 = new();
        Person person2 = new();
        Person person3 = new();
        Person person4 = new();
        Person person5 = new();
        
        people.AddRange([new Person(), person2, person3, person4, person5]);
    }

    public void LearnDictionary()
    {
        Dictionary<string, int> countryPopulation = new();
        countryPopulation.Add("Nepal", 3453535);
        countryPopulation.Add("India", 13453536);
        countryPopulation.Add("China", 73453536);
    }
}
