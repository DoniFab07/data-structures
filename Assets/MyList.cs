using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyList : MonoBehaviour
{
    public List<int> numbers = new List<int>();
    void Start()
    {
        numbers.Add(2);
        numbers.Add(4);
        numbers.Add(7);
        numbers.Add(1);
        numbers.Add(1);
        numbers.RemoveAt(0);
        numbers.Remove(1);
        AnotherMethod();
    }

    void AnotherMethod()
    {
        foreach (var t in numbers)
        {
            print(t);
        }
    }
}
