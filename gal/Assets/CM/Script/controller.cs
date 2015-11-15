using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
    public GameObject player;
    public PlayerControl cont;	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        if (name == "up")
        {
            cont.v = 1;
            cont.directionX = 0f;
            cont.directionY = 1f;

        }
        if (name == "down")
        {
            cont.v = -1;
            cont.directionX = 0f;
            cont.directionY = -1f;
        }

        if (name == "right")
        {
            cont.h = 1;
            cont.directionX = 1f;
            cont.directionY = 0f;
        }
        if (name == "left")
        {
            cont.h = -1;
            cont.directionX = -1f;
            cont.directionY = 0f;
        }
    }

    void OnMouseExit()
    {
        cont.v = 0f;
        cont.h = 0f;
     }
    void OnMouseUp()
    {
        cont.v = 0f;
        cont.h = 0f;
    }
}
