using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositiveDictionary : MonoBehaviour
{

    Dictionary<string, int> pDictionary;
    int score = 0;

    void Start()
    {
        pDictionary = new Dictionary<string, int>();
        pDictionary.Add("happy", 10);
        pDictionary.Add("like", 10);
        pDictionary.Add("meaningful", 10);
        pDictionary.Add("helpful", 10);
        pDictionary.Add("kind", 10);
        pDictionary.Add("friendly", 10);
        pDictionary.Add("cool", 10);
        pDictionary.Add("fun", 10);
        pDictionary.Add("funny", 10);
        pDictionary.Add("awesome", 10);
        pDictionary.Add("interesting", 10);
        pDictionary.Add("beautiful", 10);
        pDictionary.Add("wonderful", 10);
        pDictionary.Add("fantastic", 10);
        pDictionary.Add("incredible", 10);
        pDictionary.Add("upbeat", 10);
        pDictionary.Add("peaceful", 10);
        pDictionary.Add("satisfied", 10);
        pDictionary.Add("happiness", 10);
        pDictionary.Add("love", 10);
        pDictionary.Add("successful", 10);
        pDictionary.Add("excited", 10);


        string words = "happy";


        bool isExist = pDictionary.ContainsKey(words);
        print("if exist happy" + isExist);

        //isExist = pDictionary.ContainsKey ("hate");
        //print("if exist hate: " + isExist);




        if (isExist == true) {
            score = score + 10;
        }
        else {
            score = score + 0;
        }

        Debug.Log("this is Score" + score);
    }


    void Update()
    {
        
    }
}
