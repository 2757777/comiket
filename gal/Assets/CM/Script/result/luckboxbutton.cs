using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class luckboxbutton : MonoBehaviour {

   public  Animator result;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Button>().interactable == true)
        {
            result.enabled = false;
        }
    }
}
