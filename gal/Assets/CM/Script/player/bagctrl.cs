using UnityEngine;
using System.Collections;

public class bagctrl : MonoBehaviour {
    int n=0;
    public Canvas bag;
    public Canvas joystick;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void push()
    {
        n++;
        if (n % 2 == 0)
        {
            bag.enabled = false;
            joystick.enabled = true;        

        }
        else
        {
            bag.enabled = true;
            joystick.enabled = false;

        }            

    }
}
