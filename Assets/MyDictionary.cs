using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDictionary : MonoBehaviour
{
    private Dictionary<string, string> slovar = new Dictionary<string, string>();
    void Start()
    {
        slovar.Add("one","honda");
        slovar.Add("two","toyota");
        slovar.Add("Three","lada");
        print(slovar["one"]);
    }

}
