using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playeritem : MonoBehaviour {
    public int water,power;
    public Text wateram, poweram;
    public Text homewater, homepower;
    public Button waterB, powerB,eventbuywater,eventbuypower;
	// Use this for initialization
	void Start () {
        wateram.text = ""+water;
        poweram.text = "" + power;
        homepower.text = "" + power;
        homewater.text = "" + water;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void eventupwater()
    {
        water++;
        GetComponent<playerproperty>().money -= 400;
        if (water == 10)
        {
            eventbuywater.interactable = false;
        }
        if (water > 0)
        {
            waterB.interactable = true;
        }
    }
    void eventuppower()
    {
        power++;
        GetComponent<playerproperty>().money -= 600;
        if (power == 10)
        {
            eventbuypower.interactable = false;
        }
        if (power > 0)
        {
            powerB.interactable = true;
        }

    }
    void downwater()
    {
        water--;
        if (water == 0)
        {
            waterB.interactable = false;
        }
        if (water < 10)
        {
            eventbuywater.interactable = true;
        }

        refresh();

    }
    void downpower()
    {
        power--;
        if (power == 0)
        {
            powerB.interactable = false;
        }
        if (power < 10)
        {
            eventbuypower.interactable = true;
        }

        refresh();
    }

    void refresh()
    {
        wateram.text = "" + water;
        poweram.text = "" + power;
        homepower.text = "" + power;
        homewater.text = "" + water;

    }
}
