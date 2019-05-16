using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegativeDictionary : MonoBehaviour
{
    Dictionary<string, int> nDictionary;
    int score = 0;

    void Start()
    {
        nDictionary = new Dictionary<string, int>();

        nDictionary.Add("hate", -10);
        nDictionary.Add("dislike",-10);
        nDictionary.Add("awful", -10);
        nDictionary.Add("hopeless", -10);
        nDictionary.Add("give up", -10);
        nDictionary.Add("disappoited", -10);
        nDictionary.Add("cry", -10);
        nDictionary.Add("boring", -10);
        nDictionary.Add("what is the purpose", -10);
        nDictionary.Add("angry", -10);
        nDictionary.Add("confused", -10);
        nDictionary.Add("lonely", -10);
        nDictionary.Add("depressed", -10);
        nDictionary.Add("shame", -10);
        nDictionary.Add("scary", -10);
        nDictionary.Add("bad", -10);

       foreach(KeyValuePair<string,int> pair in nDictionary) {
            Debug.Log(pair.Key + "" + pair.Value);
       }


        bool isExist = nDictionary.ContainsKey("happy");
        print("if exist happy" + isExist);

        if (isExist == true)
        {
            score = score - 10;
        }


        Debug.Log("this is Score" + score);
    }
}
