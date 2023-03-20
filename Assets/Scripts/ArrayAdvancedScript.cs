using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Note addition of 'using System;' for array methods

public class ArrayAdvancedScript : MonoBehaviour
{
    void Start()


    {

        // UNCOMMENT THE FUNCTION YOU WANT TO RUN
        // ALL FUNCTIONS PRINT TO THE CONSOLE

        //SingleDimensionalArray();
        //MultiDimensionalArray();
        //CloneArray();
        //ClearArray();
        //ReverseArray();
        //GetSetMultidimensionalArrayValues();
        //SortAndSearchArray();
        //ArrayClassProperties();

        /* 
        Once you have come to terms with the above:
        1. Find the index of the lowest number in an array
        2. Find the index of the highest in an array
        3. Manually sort an array of integers
        4. Manually sort an array of strings
        */

    }

    // NOTE: Region tags are to make code more manageable (so you can expand and contract regions)
    // they are treated as comments and ignored by the program

    #region Sort and Search Array

    private void SortAndSearchArray()
    {
        // Create an array and add 5 items to it
        string[] stringArray = { "Mahesh", "Raj", "Neel", "Beniwal", "Chand" };

        // Find an item
        object name = "Neel";
        int nameIndex = Array.BinarySearch(stringArray, name);
        if (nameIndex >= 0)
        {
            Debug.Log("Item was at " + nameIndex.ToString() + "th position");
        }
        else
        {
            Debug.Log("Item not found");
        }

        Debug.Log("Original Array");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Debug.Log("Sorted Array");
        Debug.Log("---------------------");
        Array.Sort(stringArray);
        //  Array.Sort(stringArray, 2, 3);
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }
    }
    #endregion

    #region Array Class Properties

    private void ArrayClassProperties()
        {
            //Note the 'new int[3] is what fixes the array size/length
            int[] intArray = new int[3] { 1, 3, 5 };
            if (intArray.IsFixedSize)
            {
                Debug.Log("Array is fixed size");
                Debug.Log("Size :" + intArray.Length.ToString());
                Debug.Log("Rank :" + intArray.Rank.ToString());
                Debug.Log("Lower Bound :" + intArray.GetLowerBound(0).ToString());
                Debug.Log("Upper Bound :" + intArray.GetUpperBound(0).ToString());
        }

    }
    #endregion

    #region CloneArray
    private void CloneArray()
        {
        string[] stringArray = { "Mahesh", "Raj", "Neel", "Beniwal", "Chand" };
        Debug.Log("Original Array");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        // Clone 
        string[] clonedArray = (string[])stringArray.Clone();
        Debug.Log("Cloned Array");
        Debug.Log("---------------------");
        foreach (string str in clonedArray)
        {
            Debug.Log(str);
        }

        // Mannually Clone An Array Using ForLoop
        // We used the 'new string[stringArray.Length]' declaration so the new array is initialised with a fixed size/length as the stringArray
        string[] clonedArrayLoop = new string[stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++ )
        {
            clonedArrayLoop[i] = stringArray[i];
        }

        Debug.Log("Cloned Array using for loop");
        Debug.Log("---------------------");    
        foreach (string str in clonedArrayLoop)
        {
            Debug.Log(str);
        }

    }
    #endregion

    #region ClearArray

    private void ClearArray()
    {
        string[] stringArray = { "Mahesh", "Raj", "Neel", "Beniwal", "Chand" };
        Debug.Log("Original Array");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Debug.Log("Clear Items");
        Debug.Log("---------------------");
        Array.Clear(stringArray, 1, 2);

        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }
    }
    #endregion

    #region ReverseArray

    private void ReverseArray()
    {
        // Create an array and add 5 items to it
        string[] stringArray = { "Mahesh", "Raj", "Neel", "Beniwal", "Chand" };

        Debug.Log("Original stringArray");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        // Reverse the array using the Array.Reverse method
        Debug.Log("Reversed stringArray");
        Debug.Log("---------------------");
        Array.Reverse(stringArray);
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        //Clone the array and then reverse it using for loops
        Debug.Log(" ");
        Debug.Log("Manually Reversed stringArray After Manually Cloning");
        Debug.Log("---------------------");
        // We used the 'new string[stringArray.Length]' declaration so the new array is initialised with a fixed size/length as the stringArray
        string[] clonedArray = new string[stringArray.Length]; ;
        for (int i = 0; i < clonedArray.Length; i++)
        {
            clonedArray[i] = stringArray[i];
        }
        for (int i = 0; i < clonedArray.Length; i++)
        {
            int index = i - clonedArray.Length + 1;
            Debug.Log(-index);
            stringArray[i] = clonedArray[-index] ;
        }
        Debug.Log("Reversed Array using for loop");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

    }
    #endregion

    #region SingleDimensionalArray

    private void SingleDimensionalArray()
    {
        //Create an int array, then initialise it with 100 index's
        int[] intArray;
        intArray = new int[100];

        //Create different arrays and initialise them with a fixed size/length in the same line (shorthand of above)
        double[] doubleArray = new double[5];
        char[] charArray = new char[5];
        bool[] boolArray = new bool[2];
        string[] stringArray = new string[10];

        // Initialize a fixed array then assign data one item at a time
        int[] staticIntArray = new int[3];

        staticIntArray[0] = 1;
        staticIntArray[1] = 3;
        staticIntArray[2] = 5;

        // Read array items one by one 
        Debug.Log(staticIntArray[0]);
        Debug.Log(staticIntArray[1]);
        Debug.Log(staticIntArray[2]);

        // Initialize a fixed array and assign data to all index's at once
        int[] QuickStaticIntArray = new int[3] { 1, 3, 5 };

        // Initialize a fixed array and assign items during declaration 
        string[] strArray = new string[] { "Mahesh Chand", "Mike Gold", "Raj Beniwal", "Praveen Kumar", "Dinesh Beniwal", "Ben Jones" };

        // Read array items using foreach loop
        foreach (string str in strArray)
        {
            Debug.Log(str);
        }
    }
    #endregion

    #region MultiDimensionalArray

    private void MultiDimensionalArray()
    {
        Debug.Log("Multidimensional arrays");

        int[,] MyNumbers = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        Debug.Log(MyNumbers[0, 0]);
        Debug.Log(MyNumbers[1, 0]);
        Debug.Log(MyNumbers[2, 0]);
        Debug.Log(MyNumbers[0, 1]);
        Debug.Log(MyNumbers[1, 1]);
        Debug.Log(MyNumbers[2, 1]);

    }
    #endregion

    #region GetSetMultidimensionalArrayValues

    private void GetSetMultidimensionalArrayValues()
    {
        string[,] playerNames = new string[2, 4];
        playerNames.SetValue("Ben", 0, 0);
        playerNames.SetValue("David", 0, 1);
        playerNames.SetValue("Michael", 0, 2);
        playerNames.SetValue("Grant Lee", 0, 3);
        playerNames.SetValue("Jones", 1, 0);
        playerNames.SetValue("Bowie", 1, 1);
        playerNames.SetValue("Franti", 1, 2);
        playerNames.SetValue("Buffalo", 1, 3);
        int items1 = playerNames.GetLength(0);
        int items2 = playerNames.GetLength(1);
        Debug.Log("Get Multidimensional Array as a list");
        Debug.Log("---------------------");
        Debug.Log("The array is " + items1 + " : " + items2);
        for (int i = 0; i < items1; i++)
        {
            for (int j = 0; j < items2; j++)
            {
                Debug.Log(i.ToString() + "," + j.ToString() + ": " + playerNames.GetValue(i, j));
            }
        }
        Debug.Log("Get Multidimensional Array in pairs");
        Debug.Log("---------------------");
        Debug.Log("Firstname : Surname");
        Debug.Log(items2);
        for (int i = 0; i < items2; i++)
        {
            Debug.Log(playerNames.GetValue(0, i) + " : " + playerNames.GetValue(1, i));
        }
    }
    #endregion

}