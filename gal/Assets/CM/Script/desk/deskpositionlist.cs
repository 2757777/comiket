using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Sprites;
using System.Collections.Generic;

public class deskpositionlist : MonoBehaviour
{
     public List<Vector2> posList= new List<Vector2>();
     public List<string> polist = new List<string>();
        void Awake()
    {
        string n = "shima";
        //读取csv二进制文件  
        if (gameObject.name == "A-Block")
            n = "A-Block";  
        if (gameObject.name == "kabe")
            n = "kabe";
        TextAsset binAsset = Resources.Load(n, typeof(TextAsset)) as TextAsset;


        string[] lineArray = binAsset.text.Split('\r');

        for (int i = 0; i < lineArray.Length; i++)
        {
            string[] pos = lineArray[i].Split(',');
            posList.Add(new Vector2(float.Parse(pos[0]), float.Parse(pos[1])));
            polist.Add(pos[2]);
        }

        posList.Shuffle();

       
    }
}

static class ListExtension
{
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0,n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}

