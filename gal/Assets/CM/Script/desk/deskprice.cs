using UnityEngine;
using System.Collections;

public class deskprice : MonoBehaviour {
    public float dakimaprice;
    public float goodsprice;
    public float tapeprice;
    public float bookprice;
    public float dakimalimit;
    public float goodslimit;
    public float tapelimit;
    public float booklimit;
    public float dakimasale, tapesale, goodssale, booksale;
    public int level;
    deskproperty property;
    float maxdakima, maxtape, maxgoods, maxbook;
	// Use this for initialization
	void Start () {
        property = gameObject.GetComponent<deskproperty>();
        level = (int)property.deskLevel;
        if (property.dakimakura)
        {
            int n = Random.Range(9, 13);
            dakimaprice = n * 1000;
            dakimalimit = Random.Range(1, 3);
            //抱き枕買い取り計算
            if (level / 3 <= 15)
            {
                dakimasale = dakimaprice + ((level / 3 - 5) * 400) + (Random.Range(0, 10) * 100);
            }
            if (level / 3 > 15 && level / 3 <= 20)
            {
                dakimasale = dakimaprice + ((level / 3 - 5) * 600) + (Random.Range(0, 20) * 100);
            }
            if (level / 3 > 20)
            {
                dakimasale = dakimaprice + ((level / 3 - 5) * 900) + (Random.Range(0, 40) * 100);
            }
        }

        if (property.tape)
        {
            int n = Random.Range(5, 8);
            tapeprice = n * 1000;
            tapelimit = Random.Range(1, 4);
            //タペストリー買い取り計算
            if (level / 7 <= 8)
            {
                tapesale = tapeprice + ((level / 5 - 3) * 200) + (Random.Range(0, 10) * 100);
            }
            if (level / 7 == 9 || level / 7 == 10)
            {
                tapesale = tapeprice + ((level / 5 - 3) * 300) + (Random.Range(0, 15) * 100);
            }
            if (level / 7 > 11)
            {
                tapesale = tapeprice + ((level / 5 - 3) * 400) + (Random.Range(0, 20) * 100);
            }
        }
        if (property.goods)
        {
            int n = Random.Range(1, 3);
            goodsprice = n * 1000;
            goodslimit = Random.Range(1, 6);
            //グッズセット買い取り計算
            goodssale = goodsprice + (level / 7 - 5) * 300 + (Random.Range(0, 15) * 100);
        }
        int i = Random.Range(5, 8);
        bookprice = i * 100;
        booklimit=Random.Range(1,6);
        //新刊買い取り計算
        if (level / 9 <= 3)
        {
            booksale = bookprice + ((level / 9 - 1) * 100)+Random.Range(0,100);
        }
        else
            booksale = bookprice + (level / 9 * 200)+Random.Range(0,100);
        //
        maxbook = property.book;
        maxdakima = property.amountdakimakura;
        maxgoods = property.amountgoods;
        maxtape = property.amounttape;
	}
	
	// Update is called once per frame
	void Update () {
        if (dakimalimit > 1&&property.amountdakimakura<maxdakima/2)
        {
            dakimalimit = 1;
        }
        if (goodslimit > 1 && property.amountgoods < maxgoods *0.3&&goodslimit<=3)
        {
            goodslimit = 1;
        }
        if (goodslimit > 3 && property.amountgoods < maxgoods * 0.6)
        {
            goodslimit = 2;
        }
        if (tapelimit > 1 && property.amounttape < maxtape * 0.4)
        {
            tapelimit = 1;
        }
        if (booklimit > 1 && booklimit <= 3 && property.book < maxbook * 0.2)
        {
            booklimit = 1;
        }
        if (booklimit > 3 && property.book < maxbook * 0.5)
        {
            booklimit = 3;
        }
	}
}
