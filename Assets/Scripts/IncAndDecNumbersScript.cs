using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Note addition of 'using System;' for datatype conversion methods if you need them

public class IncAndDecNumbersScript : MonoBehaviour
{
    int MyIncrement = 1;
    int MyDecrement = 1;

    //https://www.programiz.com/csharp-programming/operators

    void Start()
    {
        //ALL FUNCTIONS PRINT TO THE CONSOLE
        /* 
        myInt += 3;
        myInt -= 3;
        myInt *= 3;
        myFloat /= 3;
        myInt++;
        myInt--;
        */

        Debug.Log("Increment a number");
        Debug.Log("---------------------");
        MyIncrement = MyIncrement + 1;
        Debug.Log(MyIncrement);
        Debug.Log("Decrement a number");
        Debug.Log("---------------------");
        MyDecrement = MyDecrement - 1;
        Debug.Log(MyDecrement);

    }

    /*
    Once you have come to terms with the above:
    1. Add soem extra lines to teh debug log
    2. Comare the pre and post processors of
            myInt++;
            myInt--;
            ++myInt;
            --myInt;
    For example:
        Debug.Log(MyDecrement);    
        Debug.Log(++MyDecrement);
        Debug.Log(MyDecrement);   

    versus
        Debug.Log(MyDecrement);    
        Debug.Log(MyDecrement++);
        Debug.Log(MyDecrement);  

    */



}