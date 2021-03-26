using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


// create a delegate of type void that calculates the sum of tow numbers
// use lambda to avoid having a dedicated method

public class Main : MonoBehaviour
{
    public Action<int, int> MySum;

    void Start()
    {
        MySum = (num1, num2) => 
        { 
            var total = num1 + num2;
            Debug.Log("Total: " + total);
        };

        MySum(1, 4);   
    }

    // void Sum2Nums(int num1, int num2)
    // {
    //     var total = num1 + num2;
    // }

}
