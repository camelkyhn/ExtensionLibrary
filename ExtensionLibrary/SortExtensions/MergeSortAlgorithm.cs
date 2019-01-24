using System.Collections.Generic;
using System.Linq;
using ExtensionLibrary.ConditionExtensions;

namespace ExtensionLibrary.SortExtensions
{
    public static class MergeSortAlgorithm
    {
        public static List<int> MergeSort(this List<int> unsortedList)
        {
            if (unsortedList.Count.IsLessOrEqualTo(1))
            {
                return unsortedList;
            }

            var leftList  = new List<int>();
            var rightList = new List<int>();

            var middle = unsortedList.Count / 2;
            for (var i = 0; i.IsLessThan(middle); i++)
            {
                leftList.Add(unsortedList[i]);
            }

            for (var i = middle; i.IsLessThan(unsortedList.Count); i++)
            {
                rightList.Add(unsortedList[i]);
            }

            leftList  = MergeSort(leftList);
            rightList = MergeSort(rightList);
            return Merge(leftList, rightList);
        }

        private static List<int> Merge(ICollection<int> leftList, ICollection<int> rightList)
        {
            var result = new List<int>();

            while(leftList.Count.IsGreaterThanZero() || rightList.Count.IsGreaterThanZero())
            {
                if (leftList.Count.IsGreaterThanZero() && rightList.Count.IsGreaterThanZero())
                {
                    if (leftList.First().IsLessOrEqualTo(rightList.First()))
                    {
                        result.Add(leftList.First());
                        leftList.Remove(leftList.First());
                    }
                    else
                    {
                        result.Add(rightList.First());
                        rightList.Remove(rightList.First());
                    }
                }
                else if(leftList.Count.IsGreaterThanZero())
                {
                    result.Add(leftList.First());
                    leftList.Remove(leftList.First());
                }
                else if (rightList.Count.IsGreaterThanZero())
                {
                    result.Add(rightList.First());
                    rightList.Remove(rightList.First());    
                }    
            }

            return result;
        }
    }
}