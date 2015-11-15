using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class baito : MonoBehaviour {
    public Canvas Schedule, information,redayevent;
    public EnergyBar baitoimage;
    public Text taihon;
    bool show,close;
    public InformationPanle inforpanle;
    float count;
    public homepro Hpro;
    public playerproperty pro;
    public Text infortext;
    public month date;
	// Use this for initialization
	void Start () {
        show = false;
        close = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (show)
        {
            baitoimage.valueCurrent++;
            if (baitoimage.valueCurrent ==100)
            {
                taihon.GetComponent<Text>().text = "僕：\n　　よし！軍資金のため、やりますか！！";
                show = false;
                close = true;
            }
        }
        if (close)
        {
            count += Time.deltaTime;
            if (count > 3)
            {
                baitoimage.valueCurrent--;
                if (baitoimage.valueCurrent == 0)
                {
                    taihon.GetComponent<Text>().text = "僕：\n　　おおお！今月の給料キタ！";
                    int money = (int)(Random.Range(2f, 4f) * 10000);
                    int exp = 10;
                    close = false;
                    count = 0;
                    pro.Exp += exp / ((pro.level + 1) / 2);
                    pro.money += money;
                    date.SendMessage("onemonth");
                    pro.SendMessage("refresh");
                    Hpro.SendMessage("refresh");
                    infortext.text = "バイト結果\n給料："+money+"円\nEXP：+10";
                    if (date.date == 8 || date.date == 12)
                    {
                        redayevent.enabled = true;
                        taihon.text = "僕：\n　　今月はイベンド開催か！";  

                    }
                    else
                    {
                        information.enabled = true;
                        inforpanle.SendMessage("ena");

                    }
                }
            }
        }
	}
    void Onclick()
    {
        show = true;
        Schedule.enabled = false;
    }


}
