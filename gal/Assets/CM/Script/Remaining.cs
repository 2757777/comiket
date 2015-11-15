using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Remaining : MonoBehaviour {
    public GameObject player;
    float analytic;
    public float many;
    bool start;
    public Canvas buylist;
    public Canvas procession;
    int minspeed;
    
	// Use this for initialization
	void Start () {
        minspeed = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (many>0&&start&&analytic>=65)
        {
            many -=minspeed * Time.deltaTime;
            gameObject.GetComponent<Text>().text = "残り:" + (int)many + "人";
        }else
        if (many > 0 && start && analytic < 65&&analytic>=50)
        {
            many -= minspeed * Time.deltaTime;
    gameObject.GetComponent<Text>().text = "残り約"+(int)many/60+"分";
            
        }else
        if(many>0&&start&&analytic<50&&analytic>35)
        {
            many -= minspeed * Time.deltaTime;
            int n = (int)many / 600;
            if(n>0)
            gameObject.GetComponent<Text>().text = "残り約" + n*10 + "分";
            else
                gameObject.GetComponent<Text>().text = "残り約10分未満";
          }
        if (many > 0 && start && analytic <= 35)
        {
            many -= minspeed * Time.deltaTime;

        }
        if(many==0&&start)
        {
            start = false;
            procession.enabled = false;
            buylist.enabled = true;
        }
        if (many <0)
        {
            start = false;
            many = 0;
            procession.enabled = false;
            buylist.enabled = true;
        }
	}
    void retsu()
    {
        minspeed = 0;
        playerproperty pro = player.GetComponent<playerproperty>();
        showzaiku zaiku = player.GetComponent<showzaiku>();
        analytic = pro.analytic;
        many = zaiku.guest;
        start = true;
        GameObject nowsakuru=player.GetComponent<PlayerControl>().nowsakuru;
        if (nowsakuru.GetComponent<deskproperty>().amountdakimakura>0)
        {
            minspeed += (int)nowsakuru.GetComponent<deskprice>().dakimalimit;
        }
        if (nowsakuru.GetComponent<deskproperty>().amounttape>0)
        {
            minspeed += (int)nowsakuru.GetComponent<deskprice>().tapelimit;
        }
        if (nowsakuru.GetComponent<deskproperty>().amountgoods>0)
        {
            minspeed += (int)nowsakuru.GetComponent<deskprice>().goodslimit;
        }
        if (nowsakuru.GetComponent<deskproperty>().book > 0)
        {
            minspeed += (int)nowsakuru.GetComponent<deskprice>().booklimit;
        }
            minspeed = (35 - minspeed*2)/4+2;
            Debug.Log(minspeed);

    }
    void exitprocession()
    {
        start = false;

    }
}
