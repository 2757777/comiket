using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class once : MonoBehaviour {
    public GameObject[] ss;
    public GameObject player;
    public Scrollbar HP, toile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void kk()
    {
        ss = GameObject.FindGameObjectsWithTag("desk");
        for (int i = 0; i < ss.Length; i++)
        {
            ss[i].GetComponent<deskposition>().DeskNumber++;
            ss[i].GetComponent<deskposition>().SendMessage("Start");
            ss[i].GetComponent<deskproperty>().SendMessage("Awake");
            ss[i].GetComponent<deskproperty>().SendMessage("Start");
            ss[i].GetComponent<deskprice>().SendMessage("Start");



        }
        player.transform.position = new Vector2(8.55f, -8.14f);
        HP.size = 1; toile.size = 1;
        
      //      sa.GetComponent<deskposition>().DeskNumber++;
       // sa.GetComponent<deskposition>().SendMessage("Start");
    }
}
