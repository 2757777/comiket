using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class run : MonoBehaviour {
    public Canvas Schedule, information, redayevent;
    public EnergyBar runimage;
    public Text taihon;
    bool show, close;
    public InformationPanle inforpanle;
    float count;
    public homepro Hpro;
    public playerproperty pro;
    public Text infortext;
    public month date;
    // Use this for initialization
    void Start()
    {
        show = false;
        close = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (show)
        {
            runimage.valueCurrent++;
            if (runimage.valueCurrent == 100)
            {
                taihon.GetComponent<Text>().text = "僕：\n　　ふ～ふ～....会場まで来たか";
                show = false;
                close = true;
            }
        }
        if (close)
        {
            count += Time.deltaTime;
            if (count > 3)
            {
                runimage.valueCurrent--;
                if (runimage.valueCurrent == 0)
                {
                    taihon.GetComponent<Text>().text = "僕：\n　　疲れた！";
                    float speed = (Random.Range(1f, 4f));
                    int exp = 10;
                    close = false;
                    count = 0;
                    pro.Exp += exp / ((pro.level + 1) / 2);
                    pro.speed += speed;
                    date.SendMessage("onemonth");
                    pro.SendMessage("refresh");
                    Hpro.SendMessage("refresh");
                    infortext.text = "ランニング結果\n速度：+" + (int)speed + "\nEXP：+10";
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
