using UnityEngine;
using System.Collections;

public class Luckprocanvas : MonoBehaviour {
    float i = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.GetComponent<Canvas>().enabled)
        {
            i += Time.deltaTime;
        }
        if (i > 2)
        {
            gameObject.GetComponent<Canvas>().enabled = false;
            i = 0;
        }
	}
}
