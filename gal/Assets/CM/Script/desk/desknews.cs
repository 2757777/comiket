using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class desknews : MonoBehaviour {
    deskproperty pro;
    public Text news;
    bool dakimanews , tapenews ,booknews,goodsnews;
 //  public  RectTransform sokuho;
	// Use this for initialization
	void Start () {
        pro = gameObject.GetComponent<deskproperty>();
        dakimanews = tapenews = booknews = goodsnews = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (pro.dakimakura&& pro.amountdakimakura < 1&&dakimanews)
        {
            news.text += "\n"+gameObject.name + "の抱き枕カバーが完売しました。";
            dakimanews = false;
                        
        }
        if (pro.goods && pro.amountgoods < 1&&goodsnews)
        {
            news.text += "\n" + gameObject.name + "のグッズセットが完売しました。";
            goodsnews = false;
        }
        if (pro.tape && pro.amounttape < 1&&tapenews)
        {
            news.text += "\n" + gameObject.name + "のタペストリーが完売しました。";
            tapenews = false;
        }
        if (pro.book < 1&&booknews)
        {
            news.text += "\n" + gameObject.name + "の新刊が完売しました。";
            booknews = false;

        }
	}
}
