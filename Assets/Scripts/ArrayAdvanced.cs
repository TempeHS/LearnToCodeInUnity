using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ArrayAdvanced : MonoBehaviour
{
    void Start()
    {


        // UNCOMMENT THE LINE YOU WANT TO RUN

        SingleDimensionalArray();
        //MultiDimensionalArray();
        // JaggedArrays();
        // ArraysSample();
        // ArrayClassProperties();
        // ArrayCreateInstanceSample();
        // SortAndSearchArray();
        // GetSetArrayValues();
        // ReverseArray();
        // ClearArray();
        // CopyArray();
        //CloneArray();

    }



    #region CloneArray
    /*
    private void CloneArray()
    {
        // Create an array and add 5 items to it
        Array stringArray = Array.CreateInstance(typeof(String), 5);
        stringArray.SetValue("Mahesh", 0);
        stringArray.SetValue("Raj", 1);
        stringArray.SetValue("Neel", 2);
        stringArray.SetValue("Beniwal", 3);
        stringArray.SetValue("Chand", 4);

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


    }
    */
    #endregion

    #region CopyArray
    /*
    private void CopyArray()
    {
        // Creates and initializes a new Array of type Int32.
        Array oddArray = Array.CreateInstance(Type.GetType("System.Int32"), 5);
        oddArray.SetValue(1, 0);
        oddArray.SetValue(3, 1);
        oddArray.SetValue(5, 2);
        oddArray.SetValue(7, 3);
        oddArray.SetValue(9, 4);
        // Creates and initializes a new Array of type Object.
        Array objArray = Array.CreateInstance(Type.GetType("System.Object"), 5);
        Array.Copy(oddArray, oddArray.GetLowerBound(0), objArray, objArray.GetLowerBound(0), 4);
        int items1 = objArray.GetUpperBound(0);
        for (int i = 0; i < items1; i++)
            Debug.Log(objArray.GetValue(i).ToString());

    }
    */
    #endregion

    #region ClearArray
    /*
    private void ClearArray()
    {
        Array stringArray = Array.CreateInstance(typeof(String), 5);
        stringArray.SetValue("Mahesh", 0);
        stringArray.SetValue("Raj", 1);
        stringArray.SetValue("Neel", 2);
        stringArray.SetValue("Beniwal", 3);
        stringArray.SetValue("Chand", 4);
        Debug.Log("Original Array");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Debug.Log();
        Debug.Log("Clear Items");
        Debug.Log("---------------------");
        Array.Clear(stringArray, 1, 2);

        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Debug.Log(stringArray.GetLength(0).ToString());
        Debug.Log(stringArray.GetLowerBound(0).ToString());
        Debug.Log(stringArray.GetUpperBound(0).ToString());

    }
    */
    #endregion

    #region ReverseArray
    /*
    private void ReverseArray()
    {
        // Create an array and add 5 items to it
        Array stringArray = Array.CreateInstance(typeof(String), 5);
        stringArray.SetValue("Mahesh", 0);
        stringArray.SetValue("Raj", 1);
        stringArray.SetValue("Neel", 2);
        stringArray.SetValue("Beniwal", 3);
        stringArray.SetValue("Chand", 4);

        Debug.Log("Original Array");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Debug.Log();
        Debug.Log("Reversed Array");
        Debug.Log("---------------------");
        Array.Reverse(stringArray);
        //  Array.Sort(stringArray, 2, 3);
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Debug.Log();
        Debug.Log("Double Reversed Array");
        Debug.Log("---------------------");
        Array.Reverse(stringArray);
        //  Array.Sort(stringArray, 2, 3);
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }
    }
    */
    #endregion

    #region GetSetArrayValues
    /*
    private void GetSetArrayValues()
    {
        Array names = Array.CreateInstance(typeof(String), 2, 4);
        names.SetValue("Rosy", 0, 0);
        names.SetValue("Amy", 0, 1);
        names.SetValue("Peter", 0, 2);
        names.SetValue("Albert", 0, 3);
        names.SetValue("Mel", 1, 0);
        names.SetValue("Mongee", 1, 1);
        names.SetValue("Luma", 1, 2);
        names.SetValue("Lara", 1, 3);
        int items1 = names.GetLength(0);
        int items2 = names.GetLength(1);
        for (int i = 0; i < items1; i++)
            for (int j = 0; j < items2; j++)
                Debug.Log(i.ToString() + "," + j.ToString() + ": " + names.GetValue(i, j));

    }
    */
    #endregion

    #region Sort and Search Array
    /*
    private void SortAndSearchArray()
    {
        // Create an array and add 5 items to it
        Array stringArray = Array.CreateInstance(typeof(String), 5);
        stringArray.SetValue("Mahesh", 0);
        stringArray.SetValue("Raj", 1);
        stringArray.SetValue("Neel", 2);
        stringArray.SetValue("Beniwal", 3);
        stringArray.SetValue("Chand", 4);

        // Find an item
        object name = "Neel";
        int nameIndex = Array.BinarySearch(stringArray, name);
        if (nameIndex >= 0)
            Debug.Log("Item was at " + nameIndex.ToString() + "th position");
        else
            Debug.Log("Item not found");

        Debug.Log();

        Debug.Log("Original Array");
        Debug.Log("---------------------");
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Debug.Log();
        Debug.Log("Sorted Array");
        Debug.Log("---------------------");
        Array.Sort(stringArray);
        //  Array.Sort(stringArray, 2, 3);
        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }
    }
    */
    #endregion

    #region ArrayCreateInstanceSample
    /*
    private void ArrayCreateInstanceSample()
    {
        Array stringArray = Array.CreateInstance(typeof(String), 3);
        stringArray.SetValue("Mahesh Chand", 0);
        stringArray.SetValue("Raj Kumar", 1);
        stringArray.SetValue("Neel Beniwal", 2);

        foreach (string str in stringArray)
        {
            Debug.Log(str);
        }

        Array intArray3D = Array.CreateInstance(typeof(Int32), 2, 3, 4);
        for (int i = intArray3D.GetLowerBound(0); i <= intArray3D.GetUpperBound(0); i++)
            for (int j = intArray3D.GetLowerBound(1); j <= intArray3D.GetUpperBound(1); j++)
                for (int k = intArray3D.GetLowerBound(2); k <= intArray3D.GetUpperBound(2); k++)
                {
                    intArray3D.SetValue((i * 100) + (j * 10) + k, i, j, k);
                }

        foreach (int ival in intArray3D)
        {
            Debug.Log(ival);
        }
    }
    */
    #endregion

    #region Array Class Properties
    /*
    private void ArrayClassProperties()
    {
        int[] intArray = new int[3] { 0, 1, 2 };
        if (intArray.IsFixedSize)
        {
            Debug.Log("Array is fixed size");
            Debug.Log("Size :" + intArray.Length.ToString());
            Debug.Log("Rank :" + intArray.Rank.ToString());
        }

    }

    */
    #endregion

    #region ArraysSample
    /*
    private void ArraysSample()
    {
        Debug.Log("Single Dimension Array Sample");
        // Single dim array
        string[] strArray = new string[] { "Mahesh Chand", "Mike Gold", "Raj Beniwal", "Praveen Kumar", "Dinesh Beniwal" };
        // Read array items using foreach loop
        foreach (string str in strArray)
        {
            Debug.Log(str);
        }
        Debug.Log("-----------------------------");

        Debug.Log("Multi-Dimension Array Sample");
        string[,] string2DArray = new string[2, 2] { { "Rosy", "Amy" }, { "Peter", "Albert" } };
        foreach (string str in string2DArray)
        {
            Debug.Log(str);
        }
        Debug.Log("-----------------------------");

        Debug.Log("Jagged Array Sample");
        int[][] intJaggedArray3 =
        {
                new int[] {2,12},
                new int[] {14, 14, 24, 34},
                new int[] {6, 16, 26, 36, 46, 56}
            };
        // Loop through all itesm of a jagged array
        for (int i = 0; i < intJaggedArray3.Length; i++)
        {
            Debug.Log("Element({0}): ", i);
            for (int j = 0; j < intJaggedArray3[i].Length; j++)
            {
                Debug.Log("{0}{1}", intJaggedArray3[i][j], j == (intJaggedArray3[i].Length - 1) ? "" : " ");
            }
            Debug.Log();
        }
        Debug.Log("-----------------------------");

    }
    */
    #endregion

    #region JaggedArrays
    /*
    private void JaggedArrays()
    {
        // Declaring jagged arrays
        int[][] intJaggedArray = new int[3][];
        string[][] stringJaggedArray = new string[2][];

        // Initializing jagged arrays
        intJaggedArray[0] = new int[2] { 2, 12 };
        intJaggedArray[1] = new int[4] { 4, 14, 24, 34 };
        intJaggedArray[2] = new int[6] { 6, 16, 26, 36, 46, 56 };

        int[][] intJaggedArray3 =
        {
                new int[] {2,12},
                new int[] {14, 14, 24, 34},
                new int[] {6, 16, 26, 36, 46, 56}
            };


        // Accessing jagged arrays
        Debug.Log(intJaggedArray3[0][0]);
        Debug.Log();
        Debug.Log(intJaggedArray3[2][5]);
        Debug.Log();

        // Loop through all itesm of a jagged array
        for (int i = 0; i < intJaggedArray3.Length; i++)
        {
            Debug.Log("Element({0}): ", i);
            for (int j = 0; j < intJaggedArray3[i].Length; j++)
            {
                Debug.Log("{0}{1}", intJaggedArray3[i][j], j == (intJaggedArray3[i].Length - 1) ? "" : " ");
            }
            System.Debug.Log();
        }

    }
    */
    #endregion

    #region SingleDimensionalArray

    private void SingleDimensionalArray()
    {
        int[] intArray;
        intArray = new int[100];
        double[] doubleArray = new double[5];
        char[] charArray = new char[5];
        bool[] boolArray = new bool[2];
        string[] stringArray = new string[10];

        // Initialize a fixed array 
        // int[] staticIntArray = new int[3] {1, 3, 5};

        // Initialize a fixed array one item at a time
        int[] staticIntArray = new int[3];

        staticIntArray[0] = 1;
        staticIntArray[1] = 3;
        staticIntArray[2] = 5;

        // Read array items one by one 
        Debug.Log(staticIntArray[0]);
        Debug.Log(staticIntArray[1]);
        Debug.Log(staticIntArray[2]);

        // Initialize a dynamic array items during declaration 
        string[] strArray = new string[] { "Mahesh Chand", "Mike Gold", "Raj Beniwal", "Praveen Kumar", "Dinesh Beniwal" };

        // Read array items using foreach loop
        foreach (string str in strArray)
        {
            Debug.Log(str);
        }
    }
 
    #endregion


    #region MultiDimensionalArray
    /*
    private void MultiDimensionalArray()
    {
        Debug.Log("Multidimensional arrays");
        //string[,] mutliDimStringArray;

        // int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        int[,] numbers = new int[3, 2];
        numbers[0, 0] = 1;
        numbers[1, 0] = 2;
        numbers[2, 0] = 3;
        numbers[0, 1] = 4;
        numbers[1, 1] = 5;
        numbers[2, 1] = 6;

        string[,] names = new string[2, 2] { { "Rosy", "Amy" }, { "Peter", "Albert" } };

        //int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        //string[,] names = { { "Rosy", "Amy" }, { "Peter", "Albert" } };

        Debug.Log(numbers[0, 0]);
        Debug.Log(numbers[1, 0]);
        Debug.Log(numbers[2, 0]);
        Debug.Log(numbers[0, 1]);
        Debug.Log(numbers[1, 1]);
        Debug.Log(numbers[2, 1]);
    }
    */
    #endregion


}