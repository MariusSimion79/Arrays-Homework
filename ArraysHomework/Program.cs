using System;
using System.Linq;

namespace ArraysHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayArray();
            //ReverseArray();
            //GetOccurencesOf();            //Using LINQ=>Count
            //InsertBeforeElement();
            RemoveElementAtIndex();
            //GetSum();                     //Using LINQ=>Sum
            //UniqueElements();             //Using LINQ=>Distinct
            //MergeAndSortAscending();      //Using LINQ=>Concat
            //GetMax();                     //using LINQ=>Max
            //GetMin();                     //using LINQ=>Min
            //SeparateOddFromEven();        //Using LINQ=>Lambda
            //SortAsc();                    //Using LINQ=>Lambda
            //SortDesc();                   //Using LINQ=>Lambda
            //FindSecondBiggest();
            //FindSecondSmallest();




        }

        #region 00 Insert a N elements Array and Find ID
        /*Insert an array with n  string elements*/
        public static string[] GetStringArray()
        {
            // get length
            Console.Write("Add the length of the arrray: ");
            int length = int.Parse(Console.ReadLine());
            // initialize
            string[] myArray = new string[length];
            // Add elements to array
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Add element {i}: ");
                myArray[i] = Console.ReadLine();
            }
            return myArray;
        }

        public static int[] GetIntArray()
        {
            // get length
            Console.Write("Add the length of the arrray: ");
            int length = int.Parse(Console.ReadLine());
            // initialize
            int[] myArray = new int[length];
            // Add elements to array
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Add element {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            return myArray;

        }
        /*Get the index of an element of the array*/
        public static int GetIndexOf(int element, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    return i;
                }
            }

            return -1;
        }


        #endregion

        #region 01 Create and display an array
        /*Write a method to create an array of 5 integers and display the array items.
         * Access individual elements and display them through indexes.*/

        public static void DisplayArray()
        {

            int[] myArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Please enter element {i + 1} of 5 of your array: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine($"Char {myArray[j]} has the index {j} in your array.");
                j++;
            }
        }
        #endregion

        #region 02  Reverse the order of the array
        /*Write a method to reverse the order of the items in the array*/
        public static void ReverseArray()
        {
            var myArray = GetIntArray();
            Array.Reverse(myArray);
            Console.Write("Your reversed array is: ");
            foreach (var elem in myArray)
            {
                Console.Write($"{elem}, ");
            }
            /*
            Console.Write("Please enter 1 for numeric array, or any number for string array: ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                var myArray = GetIntArray();
                for (int i = myArray.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{myArray[i]}, ");
                }
            }
            else
            {
                var myArray = GetStringArray();
                for (int i = myArray.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{myArray[i]}, ");
                }
            }
            */
        }
        #endregion

        #region 03 Get the number of occurences using LINQ-Count
        /*Write a method to get the number of occurrences of a specified element in an array*/
        public static void GetOccurencesOf()
        {
            var myArray = GetStringArray();
            Console.Write("Please specify the element to count: ");
            string myElement = Console.ReadLine();

            int occurence = myArray.Count(x => x == myElement);
            Console.WriteLine("****************************************************************************");
            if (occurence == 1)
            {
                Console.Write($"The element {myElement} vas found {occurence} time");
            }
            else
            {
                Console.Write($"The element {myElement} vas found {occurence} times");
            }


            /*

            int counter = 0;
            foreach (var element in myArray)
            {
                if (element == myElement)
                {
                    counter++;
                }
            }
            if (counter == 1)
            {
                Console.WriteLine($"The element {myElement} was found 1 time.");
            }
            else
            {
                Console.WriteLine($"The element {myElement} was found {counter} times.");
            }
            */
        }

        #endregion

        #region 04 Insert a new item before the second element in an existing array
        /*Write a method to insert a new item before the second element in an existing array*/
        public static void InsertBeforeElement()
        {
            var myArray = GetStringArray();
            Console.Write("Initially, your string was: ");
            foreach (var elem in myArray)
            {
                Console.Write($"{elem}, ");
            }
            Console.WriteLine();
            Console.Write("Please enter the element to insert: ");
            string elementToInsert = Console.ReadLine();
            int length = myArray.Length + 1;
            string[] myFinalArray = new string[length];
            myFinalArray[0] = myArray[0];
            myFinalArray[1] = elementToInsert;
            for (int i = 2; i < length; i++)
            {
                myFinalArray[i] = myArray[i - 1];
            }

            Console.Write("Now, your string is: ");
            foreach (var element in myFinalArray)
            {
                Console.Write($"{element}, ");
            }
        }


        #endregion

        #region 05 Remove a specified item using the index
        /*Write a method to remove a specified item using the index from an array.*/
        public static void RemoveElementAtIndex()
        {
            var myArray = GetStringArray();
            Console.Write("Please enter the index of the element to be removed: ");
            int indexToRemove = int.Parse(Console.ReadLine());
            int lengthOfSecondArray = myArray.Length - 1;



            var secondArray = new string[lengthOfSecondArray];
            int i = 0;
            while (i < lengthOfSecondArray)
            {
                if (i != indexToRemove)
                {
                    secondArray[i] = myArray[i];
                }
                else
                {
                    secondArray[i] = myArray[i + 1];
                }
                i++;
            }

            Console.WriteLine("Your Array is now: ");
            foreach (var element in secondArray)
            {
                Console.Write($"{element}, ");
            }
        }
        #endregion

        #region 06 Sum of all elements of the array
        /*Write a program to find the sum of all elements of the array*/
        public static void GetSum()
        {
            var myArray = GetIntArray();
            int sum = myArray.Sum();

            /*
            int i = 0;
            int sum = 0;
            while (i < myArray.Length)
            {
                sum += myArray[i];
                i++;
            }*/
            Console.WriteLine($"The sum of all elements of the array is: {sum}.");

        }

        #endregion

        #region 07 Print unique elements in an array
        /*Write a program to print all unique elements in an array.*/
        public static void UniqueElements()
        {
            var myArray = GetIntArray();
            var arrayToPrint = myArray.Distinct();
            Console.Write("Your unique elements in array are: ");
            foreach (var elem in arrayToPrint)
            {
                Console.Write($"{elem}, ");
            }

            /*
            int[] arrayToPrint = new int[myArray.Length];

            var index = -1; // to know where to add our unique element
            var stringToPrint = string.Empty; // ""

            for (int i = 0; i < myArray.Length; i++)
            {
                if (GetIndexOf(myArray[i], arrayToPrint) == -1)
                {
                    index++;
                    arrayToPrint[index] = myArray[i];
                }
            }
            
            Console.Write("Your unique elements of array are: ");
            for (int i = 0; i <= index; i++)
            {
                Console.Write($"{arrayToPrint[i]}, ");
            }*/

        }
        #endregion

        #region 08 Merge 2 same size arrays in ascending order
        /*Write a program to merge two arrays of same size sorted in ascending order.*/
        public static void MergeAndSortAscending()
        {
            var myArray1 = GetIntArray();
            var myArray2 = GetIntArray();
            var mergedArray = myArray1.Concat(myArray2).ToArray();
            Array.Sort(mergedArray);

            /*
            var mergedArray = new int[myArray1.Length + myArray2.Length];

            int i = 0;
            int temp = 0;
            while (i < mergedArray.Length)
            {
                if (i < myArray1.Length)
                {
                    mergedArray[i] = myArray1[i];
                }
                else
                {
                    mergedArray[i] = myArray2[i - myArray1.Length];
                }
                i++;
            }
            for (int j = 0; j < mergedArray.Length - 1; j++)
            {
                for (int k = j + 1; k < mergedArray.Length; k++)
                {
                    if (mergedArray[j] < mergedArray[k])
                    {
                        temp = mergedArray[j];
                        mergedArray[j] = mergedArray[k];
                        mergedArray[k] = temp;
                    }
                }
            }*/
            Console.WriteLine();
            foreach (var elem in mergedArray)
            {
                Console.Write($"{elem},");
            }
        }
        #endregion

        #region 09 Maximum element in array using LINQ Max()
        /*Write a program to find maximum and minimum element in an array.*/
        public static void GetMax()
        {
            var myArray = GetIntArray();
            int max = myArray.Max();

            /*
            for (int i = 0; i < myArray.Length; i++)
            {
                if (max < myArray[i])
                {
                    max = myArray[i];
                }
            }
            */
            Console.WriteLine($"The biggest element in your array is: {max}");
        }
        #endregion

        #region 10 Minimum element in array using LINQ Min()
        /*Write a program to find maximum and minimum element in an array.*/
        public static void GetMin()
        {
            var myArray = GetIntArray();
            int min = myArray.Min();
            /*
            for (int i = 0; i < myArray.Length; i++)
            {
                if (min > myArray[i])
                {
                    min = myArray[i];
                }
            }
            */
            Console.WriteLine($"The smallest element in your array is: {min}");
        }
        #endregion

        #region 11 Separate Odd from Even using LINQ Select Where
        /*Write a program to separate odd and even integers in separate arrays*/
        public static void SeparateOddFromEven()
        {
            var myArray = GetIntArray();
            var even = myArray.Select(x => x % 2 == 0);
            var even2 = myArray.Where(x => x % 2 == 0);
            Console.Write("Numerele pare din array sunt: ");
            foreach (var ev2 in even2)
            {
                Console.Write($"{ev2}, ");
            }
            Console.WriteLine();
            var odd = myArray.Select(x => x % 2 != 0);
            var odd2 = myArray.Where(x => x % 2 != 0);
            Console.Write("Numerele impare din array sunt: ");
            foreach (var od2 in odd2)
            {
                Console.Write($"{od2}, ");
            }
            /*


            int countEven = 0;
            int countOdd = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            var myEvenArray = new int[countEven];
            var myOddArray = new int[countOdd];
            int odd = 0;
            int even = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    myEvenArray[even] = myArray[i];
                    even++;
                }
                else
                {
                    myOddArray[odd] = myArray[i];
                    odd++;
                }
            }
            Console.WriteLine("The even elements of your first array are: ");
            foreach (var element in myEvenArray)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();
            Console.WriteLine("The odd elements of your first array are: ");
            foreach (var element in myOddArray)
            {
                Console.Write($"{element}, ");
            }
            */
        }




        #endregion

        #region 12 Sort array`s element in ascending order
        /*Write a program to sort elements of array in ascending order.*/
        public static void SortAsc()
        {
            var myArray = GetIntArray();
            Array.Sort<int>(myArray);


            /*
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            */
            Console.Write("Array-ul sortat crescator este: ");
            foreach (var elem in myArray)
            {
                Console.Write($"{elem},");
            }

        }

        #endregion

        #region 13 Sort array`s element in descending order
        /*Write a program to sort elements of the array in descending order.*/
        public static void SortDesc()
        {
            var myArray = GetIntArray();
            Array.Sort<int>(myArray);
            Array.Reverse<int>(myArray);


            /*
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            */
            Console.WriteLine("Array-ul sortat descrescator este: ");
            foreach (var elem in myArray)
            {
                Console.Write($"{elem},");
            }
        }
        #endregion

        #region 14 Find the second largest element in a array
        /*Write a program to find the second largest element in an array.*/
        public static void FindSecondBiggest()
        {
            var myArray = GetIntArray();
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] < myArray[j])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }

            Console.WriteLine($"The second biggest element in your array is {myArray[1]}");
        }



        #endregion

        #region 15 Find the second smaller element in a array
        /*Write a program to find the second smallest element in an array.*/
        public static void FindSecondSmallest()
        {
            var myArray = GetIntArray();
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            Console.WriteLine($"The second smallest element in your array is {myArray[1]}");
        }


        #endregion
    }
}
