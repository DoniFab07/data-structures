using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyArray : MonoBehaviour
{
    public int[] f = new int[] {1, 2, 3, 4};// создать и заполнить массив
    public int test;
    private int max = 0;
    void Start()
    {
      test = f[1]; // обращаемся к элементу массива

      for (var i = 0; i < f.Length; i++)
      {
          if (f[i] > max) max = f[i];
      }
      print(max);
    }
}
