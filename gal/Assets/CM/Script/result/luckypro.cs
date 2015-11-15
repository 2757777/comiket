using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class luckypro : MonoBehaviour {
    public int plus;
    public int which;
    public playerproperty pro;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void plusmoney()
    {
        GetComponentInParent<Canvas>().enabled = true;
        plus = Random.Range(1, 6);
        gameObject.GetComponentInChildren<Text>().text =
    "お金     +" + (plus*1000);
        pro.money += plus * 1000;

    }
    void pluspiont()
    {
        GetComponentInParent<Canvas>().enabled = true;
         which = Random.Range(0, 4);
         plus=Random.Range(1,6);
        switch (which)
        {
                //知識
            case 0:
                gameObject.GetComponentInChildren<Text>().text =
                    "知識     +" + plus;
                pro.knowledge += plus;
                break;
                //分析力
            case 1:
                gameObject.GetComponentInChildren<Text>().text =
                    "分析力     +" + plus;
                pro.analytic += plus;
                break;
                //忍耐力
            case 2:
                gameObject.GetComponentInChildren<Text>().text =
                    "忍耐力     +" + plus;
                pro.fortitude += plus;
                break;
            //社交力
            case 3:
                gameObject.GetComponentInChildren<Text>().text =
                    "社交力     +" + plus;
                pro.sociable += plus;
                break;
        }

    }
  
}
