using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class newswindow : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void openwindow()
    {
       gameObject.GetComponent<Canvas>().enabled = true;
    }
    void closewindow()
    {
        gameObject.GetComponent<Canvas>().enabled = false;
    }
}
