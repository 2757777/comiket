using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class month : MonoBehaviour {
   public int date;
	// Use this for initialization
	void Start () {
        date = 8;
        GetComponent<Text>().text = date + "月";

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void onemonth()
    {

        date++;
        if (date == 13)
        {
            date = 1;
        }
        GetComponent<Text>().text = date + "月";

    }
}
