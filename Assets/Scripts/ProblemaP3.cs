using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemaP3 : MonoBehaviour
{
    public int[] arreglo = new int[9] {-2,1,-3,4,-1,2,1,-5,4};

    // Update is called once per frame
    void Start()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {

            Debug.Log(SumaSubArreglo(arreglo));
        }
    }

    private int SumaSubArreglo(int[] nums)
    {
        int sums = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i+1] > nums[i])
            {
                sums = sums + nums[i+1];
            }

            else
            {
                sums = nums[i+1];
            }
            
        }
        Debug.Log(sums);
        return sums;
    }









}
