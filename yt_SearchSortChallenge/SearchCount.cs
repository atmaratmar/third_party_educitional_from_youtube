using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yt_SearchSortChallenge
{
    public class SearchCount
    {
        private int _numberOfElements;

        public SearchCount(int NumberOfElements)
        {
            this._numberOfElements = NumberOfElements;
            Counter = 0;
            Numbers = new int[NumberOfElements];
        }

        public int[] Numbers { get; set; }
        public int Counter { get; set; }

        public void LinearSearch(int searchedValue)
        {
            for (var i = 0; i < _numberOfElements; i++)
            {
                Counter++;
                if (Numbers[i] == searchedValue)
                    return;
            }
        }

        public void BinarySearch(int searchedValue)
        {
            var maxpoint = _numberOfElements;
            var minpoint = 0;

            do
            {
                int midpoint = minpoint + (maxpoint - minpoint)/2;
                Counter++;
                if (Numbers[midpoint] == searchedValue)
                    return;
                else if (Numbers[midpoint] < searchedValue)
                {
                    minpoint = midpoint + 1;
                }
                else
                {
                    maxpoint = midpoint - 1;
                }
            } while (minpoint <= maxpoint);
        }

        public void BubbleAscSort()
        {
            for (var i = 0; i < _numberOfElements - 1; i++)
            {
                for (var c = i + 1; c < _numberOfElements; c++)
                {
                    if (Numbers[c] < Numbers[i])
                    {
                        var temp = Numbers[i];
                        Numbers[i] = Numbers[c];
                        Numbers[c] = temp;
                    }
                }
            }
        }

        public void SelectionDescSort()
        {
            for (var i = 0; i < _numberOfElements - 1; i++)
            {
                var highest = Numbers[i];
                var highestIndex = 0;
                for (var c = i + 1; c < _numberOfElements; c++)
                {
                    if (Numbers[c] > highest)
                    {
                        highest = Numbers[c];
                        highestIndex = c; //get index if this is new highest number
                    }
                }

                if (Numbers[i] != Numbers[highestIndex])
                {
                    var temp = Numbers[i];
                    Numbers[i] = Numbers[highestIndex];
                    Numbers[highestIndex] = temp;
                }
            }
        }
    }
}
