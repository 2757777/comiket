using UnityEngine;
using System.Collections;


public class deskposition : MonoBehaviour {

    public GameObject deskpiont;

    public int DeskNumber;
    public string ichi;
    deskpositionlist piont;
	// Use this for initialization
	void Start () {
        if (transform.parent.gameObject.name == "A-Block" && DeskNumber == 16)
        {
            DeskNumber = 0;
        }
        if (transform.parent.gameObject.name == "kabe" && DeskNumber == 12)
        {
            DeskNumber = 0;
        }
        if (transform.parent.gameObject.name == "shima" && DeskNumber == 112)
        {
            DeskNumber = 0;
        }
       // deskpositionlist 
        piont = deskpiont.GetComponent<deskpositionlist>();
        // piont.Start();
        gameObject.transform.position = new Vector2(piont.posList[DeskNumber].x, piont.posList[DeskNumber].y);
        ichi = piont.polist[DeskNumber];
	}
	
	// Update is called once per frame
	void Update () {

	}
}
