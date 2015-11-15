using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class maku : MonoBehaviour {
    public Image col;
    float i ,n;
    public Canvas kbooks,home;
    public Canvas bag;
    public Image backimage;
    public GameObject panel;
    public Text sale;
    public Button salebutton;
    public Image map, mark;
    public Homeinformation Him;
    public month month;
    public Image HomeinfoPanel;
	// Use this for initialization
	void Start () {
         i = 0;
         n = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (n > 3.5)
        {
            col.color = new Vector4(0, 0, 0, i);
            i += Time.deltaTime * 0.7f;
        }
        if (n > 6&&name=="akimaku")
        {
            i = 0;
            map.enabled=false;
            mark.enabled=false;
            kbooks.enabled = true;
            bag.enabled = true;
            n = 0;
            sale.text = "";
            backimage.enabled = true;
            col.color = new Vector4(0, 0, 0, 0);
            this.gameObject.GetComponent<maku>().enabled = false;
            salebutton.GetComponent<Button>().interactable = false;
        }
        if (n > 6 && name == "ikemaku") 
        {
            i = 0;
            HomeinfoPanel.enabled = true;
            HomeinfoPanel.GetComponentInChildren<Text>().enabled = true;
            Him.enabled = true;
            Him.SendMessage("Start");
            map.enabled = false;
            mark.enabled = false;
            home.enabled = true;
            month.SendMessage("onemonth");
            n = 0;
            sale.text = "";
            col.color = new Vector4(0, 0, 0, 0);
            this.gameObject.GetComponent<maku>().enabled = false;

        }
        if (n > 6 && name == "kbooksmaku")
        {
            i = 0;
            HomeinfoPanel.enabled = true;
            HomeinfoPanel.GetComponentInChildren<Text>().enabled = true;
            Him.enabled = true;
            Him.SendMessage("Start");
            map.enabled = false;
            mark.enabled = false;
            month.SendMessage("onemonth");
            home.enabled = true;
            col.color = new Vector4(0, 0, 0, 0);
            this.gameObject.GetComponent<maku>().enabled = false;
            salebutton.GetComponent<Button>().interactable = false;

        }


        n += Time.deltaTime;
    }
}
