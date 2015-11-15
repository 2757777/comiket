using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class library : MonoBehaviour {
    public Canvas Schedule, information, redayevent;    
    public EnergyBar libraryimage;
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
            libraryimage.valueCurrent++;
            if (libraryimage.valueCurrent == 100)
            {
                taihon.GetComponent<Text>().text = "僕：\n　　たまには立ち読みするか！";
                show = false;
                close = true;
            }
        }
        if (close)
        {
            count += Time.deltaTime;
            if (count > 3)
            {
                libraryimage.valueCurrent--;
                if (libraryimage.valueCurrent == 0)
                {
                    taihon.GetComponent<Text>().text = "僕：\n　　何か分かるかも！";
                    float knowledge = Random.Range(1f, 4f);
                    int exp = 10;
                    close = false;
                    count = 0;
                    pro.Exp += exp / ((pro.level + 1) / 2);
                    pro.knowledge += knowledge;
                    date.SendMessage("onemonth");
                    pro.SendMessage("refresh");
                    Hpro.SendMessage("refresh");
                    infortext.text = "立ち読み結果\n知識：+" + (int)knowledge + "\nEXP：+10";
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
