using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {

        // here we read the file that we send its path in the paramters
        static void AddResultCenter(string path, Candidate[] candidates)
        {
            string[] Lines1 = File.ReadAllLines(path);
            Console.WriteLine("Number             Name");
            Console.WriteLine("----------------------------------");
            // make loop on every line inside the file 
            for (int i = 0; i < Lines1.Length; i++)
            {
                string line = Lines1[i];
                // break every line to array of pieces based on the "," 
                string[] elements = line.Split(',');

                // make array on this array that we've gotten of break every line
                for (int j = 0; j < elements.Length; j++)
                {
                    int element = int.Parse(elements[j]);
                    // check the element(that is a vote) value and add a vote to the 
                    // corrspond candidate 
                    if ( element == 1)
                    {
                        candidates[0].AddVote();
                    }
                    else if (element == 2)
                    {
                        candidates[1].AddVote();
                    }
                    else if (element == 3)
                    {
                        candidates[2].AddVote();
                    }
                    else if (element == 4)
                    {
                        candidates[3].AddVote();
                    }
                    // here we check the element value if it is out of the total 
                    // numbers of candidate we print error message
                    else
                    {
                        Console.WriteLine("There no Candidate with number {0}", elements);
                    }
                }
            }
            int total = 0;
            // for calculte the total of votes across all candidate
            for (int i = 0; i < candidates.Length; i++)
            {
                total += candidates[i].Votes;
            }
            // print the name with number of votes with percent
            for (int i = 0; i < candidates.Length; i++)
            {
                candidates[i].ClacPercent(total);
                Console.WriteLine("{0}                  {1}                   {2}", candidates[i].Votes,candidates[i].Percent, candidates[i].Name);
            }
        }
        static void Main(string[] args)
        {
            // Create an array to colllect all the Candidates
            // So that how we can deal with them by this array
            Candidate[] candidates = new Candidate[4];

            try
            {
                // ask user to enter the path of name file
                Console.WriteLine("Enter the path of name");
                string Path = @"C:\Users\Mohammed Al-yaseen\Downloads\Telegram Desktop\HW_Part1\names.txt";
                Path = Console.ReadLine();

                string[] Lines1 = File.ReadAllLines(Path);
                Console.WriteLine("Number             Name");
                Console.WriteLine("----------------------------------");
                // make loop on every line inside the file 
                for (int i = 0; i < Lines1.Length; i++)
                {
                    string line = Lines1[i];
                    // break every line to array of pieces based on the "," 
                    string[] elements = line.Split(',');
                    int Number = int.Parse(elements[0]);
                    string Name = elements[1];
                    // initialize each candidate object with its values
                    candidates[i] = new Candidate(Number, Name);
                    Console.WriteLine("{0}                  {1}",Number,Name);
                }

                AddResultCenter(@"C:\Users\Mohammed Al-yaseen\Downloads\Telegram Desktop\HW_Part1\center1.txt", candidates);
                AddResultCenter(@"C:\Users\Mohammed Al-yaseen\Downloads\Telegram Desktop\HW_Part1\center2.txt", candidates);
                AddResultCenter(@"C:\Users\Mohammed Al-yaseen\Downloads\Telegram Desktop\HW_Part1\center3.txt", candidates);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
           }
            Console.ReadKey();
        }
    }
}
