using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class think : MonoBehaviour {

	// Use this for initialization
    public Canvas Schedule, information, redayevent;
    public EnergyBar thinkimage;
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
            thinkimage.valueCurrent++;
            if (thinkimage.valueCurrent == 100)
            {
                taihon.GetComponent<Text>().text = "僕：\n　　夜の郊外は最高だね！星が綺麗！";
                show = false;
                close = true;
            }
        }
        if (close)
        {
            count += Time.deltaTime;
            if (count > 3)
            {
                thinkimage.valueCurrent--;
                if (thinkimage.valueCurrent == 0)
                {
                    taihon.GetComponent<Text>().text = "僕：\n　　スッキリした感じ！";
                    float analytic = Random.Range(1f, 4f);
                    int exp = 10;
                    close = false;
                    count = 0;
                    pro.Exp += exp / ((pro.level + 1) / 2);
                    pro.analytic += analytic;
                    date.SendMessage("onemonth");
                    pro.SendMessage("refresh");
                    Hpro.SendMessage("refresh");
                    infortext.text = "瞑想結果\n分析力：+" + (int)analytic + "\nEXP：+10";
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
