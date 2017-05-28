//Create a class named "SearchCount". It includes an array of 20 elements (int type) and a variable named counter. 
//It also includes constructors, properties, and four functions: liner search, binary search, 
//bubble ascending sorting, and selection descending sort.
//Create a class named "SearchCountDemo". In the main function, read the data from file and create an 
//array of objects with three elements to save the data. 
//Search number 26 using:
//element 1. liner search 
//element 2. bubble ascending sorting -> binary search
//element 3. selection descending sort -> binary search
//keep counters for each function and print out the number of searching step for comparison.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yt_SearchSortChallenge
{
    class SearchCountDemo
    {
        static void Main(string[] args)
        {
            const int n_numberOfElements = 20;
            const int searchedValue = 26;
            const string path = "numbers.txt";
            var element1 = new SearchCount(n_numberOfElements);
            var element2 = new SearchCount(n_numberOfElements);
            var element3 = new SearchCount(n_numberOfElements);

            var results = new SearchCount[] {element1, element2, element3};

            using (var sr = new StreamReader(path))
            {
                var line = new string[n_numberOfElements];
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine().Split(' ');
                }

                for (var i = 0; i < n_numberOfElements; i++)
                {
                    element1.Numbers[i] = Convert.ToInt32(line[i]);
                    element2.Numbers[i] = Convert.ToInt32(line[i]);
                    element3.Numbers[i] = Convert.ToInt32(line[i]);
                }

                element1.LinearSearch(searchedValue);
                element2.BubbleAscSort();
                element2.BinarySearch(searchedValue);
                element3.SelectionDescSort();
                element3.BinarySearch(searchedValue);

                for (var i=0; i < 3; i++)
                    Console.WriteLine("Element {0} counter = {1}", i + 1, results[i].Counter);

                Console.ReadKey();
            }
        }
    }
}
