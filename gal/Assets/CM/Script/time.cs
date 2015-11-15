using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class time : MonoBehaviour {
    public int hour;
    public int min1,min2;
    float i = 0;
    Text te;
	// Use this for initialization
	void Start () {
        te = gameObject.GetComponent<Text>();
        hour = 10;
        min1 =min2= 0;
	}
	
	// Update is called once per frame
	void Update () {
        te.text = hour + ":" + min1+min2;
        if (i >= 3)
        {
            min2++;
            i = 0;
        }
        i += Time.deltaTime;
        if (min2 == 10)
        {
            min1++;
            min2 = 0;
        }
        if (min1 == 6)
        {
            hour++;
            min1 = min2 = 0;
        }
	}
}
