using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHashSet : MonoBehaviour
{
    HashSet<int> hash = new HashSet<int>(3);
    void Start()
    {
        hash.Add(1);
        hash.Add(2);
        print(hash);
    }

  
}
