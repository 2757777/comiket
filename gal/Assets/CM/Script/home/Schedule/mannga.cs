using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mannga : MonoBehaviour {

    public Canvas Schedule, information, redayevent;
    public EnergyBar mangaimage;
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
            mangaimage.valueCurrent++;
            if (mangaimage.valueCurrent == 100)
            {
                taihon.GetComponent<Text>().text = "僕：\n　　ここだけがコミュニケーションできる場所だな....";
                show = false;
                close = true;
            }
        }
        if (close)
        {
            count += Time.deltaTime;
            if (count > 3)
            {
                mangaimage.valueCurrent--;
                if (mangaimage.valueCurrent == 0)
                {
                    taihon.GetComponent<Text>().text = "僕：\n　　いっぱい話したぜ！";
                    float sociable = (Random.Range(1f, 4f));
                    int exp = 10;
                    close = false;
                    count = 0;
                    pro.Exp += exp / ((pro.level + 1) / 2);
                    pro.sociable += sociable;
                    date.SendMessage("onemonth");
                    pro.SendMessage("refresh");
                    Hpro.SendMessage("refresh");
                    infortext.text = "マンガ喫茶で住む結果\n社交力：+" + (int)sociable + "\nEXP：+10";
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
