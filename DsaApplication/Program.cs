using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaApplication
{

    class Program
    {
        static int[] Arr = new int[] { 5, 2, 7, 8, 3, 5, 7, 1, 9, 0 };

        static void Main(string[] args)
        {

            //**************** sorting ********************//
            //CArray nums = new CArray(10);
           // Random rnd = new Random(100);
           // for (int i = 0; i < 10; i++)
           // nums.Insert((int)(rnd.NextDouble() * 100));
           // Console.WriteLine("Before sorting: ");
           // nums.DisplayElements();
           // Console.WriteLine("During sorting: ");
          //  nums.InsertionSort();
           // Console.WriteLine("After sorting: ");
           // nums.DisplayElements();


            //******************************* searching ************************//
            int found;
            int searchnumber;
            Console.WriteLine("Enter the nunber you want to search for.");
            searchnumber = Convert.ToInt32(Console.ReadLine(), 10);
            found = binSearch(searchnumber);
            if (found > -1)
            {
                Console.WriteLine("the number has been found");
            }
            else
            {
                Console.WriteLine("not found");
            }

            //***************** Find minimum value in an array *******************************//
            //int[] numbers = new int[] { 2, 3, 4, 5, 1, 6, 8, 9 };
            //int min = FindMin(numbers);
            //Console.WriteLine("the minimum number is " + min);


            //*************** find mmx value in an array *********************************//
            //int[] numbers = new int[] { 2, 3, 4, 5, 1, 6, 8, 9, 10 };
            //int max = FindMax(numbers);
            //Console.WriteLine("the maximum value is " + max);


            //***********************search with self organizing data *****************************
          
            Console.ReadLine();

        }

        public static void swap(int item1, int item2)
        {
            int temp = item1;
            Arr[item1] = Arr[item1];
            Arr[item2] = temp;
        }

        //array search function
        public static bool SeqSearch(int[] Arr, int sValue)
        {
            for (int index = 0; index < Arr.Length; index ++)
            {
                if (Arr[index] == sValue)
                {
                    //self organinzing feature
                   swap(index, index - 1);
                   return true;
                }
            }
            return false;
        }

        public static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int binSearch(int value)
        {
            int UpperBound, LowerBound, mid;
            UpperBound = Arr.Length - 1;
            LowerBound = 0;
            while (LowerBound <= UpperBound)
            {
                mid = (UpperBound + LowerBound) / 2;
                if (Arr[mid] == value)
                {
                    return mid;
                }
                else
                {
                    if (value < Arr[mid])
                    {
                        UpperBound = mid - 1;
                    }
                    else
                    {
                        LowerBound = mid + 1;
                    }
                }
            }
            return -1;
        }

    }
}
