using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InformationPanle : MonoBehaviour {
    bool can;
    float n;
    public Canvas Schedule;
    public Text taihon;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (can)
        {
            if (n > 1.5)
            {

                GetComponent<Canvas>().enabled = false;
                n = 0;
                Schedule.enabled = true;
                taihon.text = "僕：\n　　さて、今月なにをするかな？";
                can = false;

            }
            n+=Time.deltaTime;
        }


	}
    void ena()
    {
        can = true;
    }
}
