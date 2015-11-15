using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class pluslist : MonoBehaviour {

    public int dakimac, tapec, goodsc, booksc;
    Text list;
    public int dakimalimit, tapelimit, goodslimit, bookslimit;
    public int dakimam, tapem, goodsm, booksm,total;
    public int desklevel;
    public float dakimasale, tapesale, goodssale, booksale; 
    public playerproperty pro;
    public Button enter;
    public string Circlename;
    public useallmoney usemoney;
    public showzaiku zaiku;
	// Use this for initialization
	void Start () {
        list = gameObject.GetComponent<Text>();
        dakimac = tapec = goodsc = booksc = desklevel=0;
	}
	
	// Update is called once per frame
	void Update () {
	}
    void reset()
    {
        dakimac = tapec = goodsc = booksc = total = desklevel=0;
        reslist();
    }
    void buy()
    {
        usemoney.SendMessage("plus");
        pro.money -= total;
        for (int i = 0; i < dakimac;i++ )
        {
            zaiku.SendMessage("dakimamin");
        }
        for (int i = 0; i < tapec; i++)
        {
            zaiku.SendMessage("tapemin");
        }
        for (int i = 0; i < goodsc; i++)
        {
            zaiku.SendMessage("goodsmin");
        }
        for (int i = 0; i < booksc; i++)
        {
            zaiku.SendMessage("bookmin");
        }
            dakimac = tapec = goodsc = booksc = total = 0;
        reslist();

    }
    void plusdakima()
    {
        if (dakimac < dakimalimit)
        {
            total += dakimam;
            dakimac++;
            reslist();
        }
    }
    void plustape()
    {
        if (tapec < tapelimit)
        {
            total += tapem;
            tapec++;
            reslist();
        }
    }
    void plusgoods()
    {
        if (goodsc < goodslimit)
        {
            total += goodsm;
            goodsc++;
            reslist();
        }
    }
    void plusbooks()
    {
        if (booksc < bookslimit)
        {
            total +=booksm;
            booksc++;
            reslist();
        }
    }
    void reslist() 
    {
        if (total > pro.money)
        {
            enter.interactable = false;
        }
        list.text = "抱き枕カバー    " + dakimac + "\n\n" +
                    "タペストリー    " + tapec + "\n\n" +
                    "グッズセット    " + goodsc + "\n\n" +
                    "新刊            " + booksc + "\n\n"+
                    "合計            "+total+"円" ;
    }
}
