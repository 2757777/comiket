using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Homeinformation : MonoBehaviour {
   public  GameObject bag;
   public int exp;
   GameObject sot;
   int Count;
   float n;
   public Image panle;
   bool show;
   public playerproperty pro;
   public homepro Hpro;
   public Text taihon;
   public Canvas Schedule; 
	// Use this for initialization
	void Start () {
        show = true;
        n = 0;
        int Count = bag.transform.childCount;
        GetComponent<Text>().text = "戦利品　"+Count+"点";
        speech(Count);

        /*for (int i = 0; i <= Count; i++)
        {
            // GameObject sot = bag.transform.FindChild("books(Clone)").gameObject;
            exp += GameObject.Find("books(Clone)").GetComponent<BagButtonProperty>().level;
            // Destroy(sot);
        }*/
        
	}
	
	// Update is called once per frame
	void Update () {
        //経験値アップ
        if(bag.transform.childCount>0)
        {
            if (GameObject.Find("books(Clone)"))
            {
                sot = GameObject.Find("books(Clone)");
                exp += sot.GetComponent<BagButtonProperty>().level;
                Destroy(sot);
                
            }
            else
                if (GameObject.Find("dakima(Clone)"))
                {
                    sot = GameObject.Find("dakima(Clone)");
                    exp += sot.GetComponent<BagButtonProperty>().level;
                    Destroy(sot);
                }
                else
                    if (GameObject.Find("tape(Clone)"))
                    {
                        sot = GameObject.Find("tape(Clone)");
                        exp += sot.GetComponent<BagButtonProperty>().level;
                        Destroy(sot);
                    }
                    else
                        if (GameObject.Find("goods(Clone)"))
                        {
                            sot = GameObject.Find("goods(Clone)");
                            exp += sot.GetComponent<BagButtonProperty>().level;
                            Destroy(sot);
                        }
               
        }
        if (bag.transform.childCount == 0&&show)
        {
            pro.Exp += exp/((pro.level+1)/2);
            pro.SendMessage("refresh");
            GetComponent<Text>().text += "\nExp : +" + exp;
            exp = 0;
            show = false;
            Hpro.SendMessage("refresh");

        }
        //パネル消す
        if (n > 2)
        {
            gameObject.GetComponent<Text>().enabled = false;
            panle.enabled = false;
            GetComponent<Homeinformation>().enabled = false;
            n = 0;
            Schedule.enabled = true;
            taihon.text = "僕：\n　　さて、今月なにをするかな？";
        }
        n += Time.deltaTime;

	}
    void speech(int t)
    {
        if (t == 0)
            taihon.text = "僕：\n　　今回は何にも持ち帰らなかったか。";
        else
            taihon.text = "僕：\n　　いっぱい買いました！最高！";
        
    }
}
