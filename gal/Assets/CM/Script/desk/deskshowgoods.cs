using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deskshowgoods : MonoBehaviour {
    public GameObject shinana;
    public playerproperty pro;
    public showzaiku zaiku;
    float analytic;
    bool show=false;
    public int guest;
    public Text dakimaprice, tapeprice, goodsprice, booksprice, dakimalimit, tapelimit, goodslimit, bookslimit;
    public Button dakima, tape, goods, books;
    public pluslist list;
	// Use this for initialization
	void Start () {
	}   
	
	// Update is called once per frame
	void Update () {
        if (show)
        {
            //トップに表示
            analytic = pro.analytic;
            deskprice limit = gameObject.GetComponent<deskprice>(); 
            deskproperty shina = gameObject.GetComponent<deskproperty>();
            Text saku = shinana.GetComponent<Text>();
             zaiku.guest = (int)shina.guests;
             list.dakimalimit = (int)limit.dakimalimit; list.dakimam = (int)limit.dakimaprice; list.dakimasale = limit.dakimasale;
             list.tapelimit = (int)limit.tapelimit; list.tapem = (int)limit.tapeprice; list.tapesale = limit.tapesale;
             list.goodslimit = (int)limit.goodslimit; list.goodsm = (int)limit.goodsprice; list.goodssale = limit.goodssale;
             list.bookslimit = (int)limit.booklimit; list.booksm = (int)limit.bookprice; list.booksale = limit.booksale;
             list.desklevel = (int)shina.deskLevel;
             list.Circlename = gameObject.name;

            if (analytic <= 50)
            {
                saku.text = "なんにもわからない.....";
            }
            //2
            if (analytic > 50 && analytic <= 60)
                saku.text = "新刊                  " + book1(shina.book) + "\n" + tape1(shina.tape) + "\n" + dakima1(shina.dakimakura) + "\n" + goods1(shina.goods);

            //3
            if (analytic > 60 && analytic < 70)
            {
                saku.text = book3(shina.book) + "\n"
                    + tape3(shina.tape, shina.amounttape) + "\n"
                    + dakima3(shina.dakimakura, shina.amountdakimakura) + "\n"
                    + goods3(shina.goods, shina.amountgoods);
            }
            //4
            if (analytic >= 70 && analytic < 90)
            {
                saku.text = book4(shina.book, limit.bookprice, limit.booklimit) + "\n"
                            + tape4(shina.tape, shina.amounttape, limit.tapeprice, limit.tapelimit) + "\n"
                            + dakima4(shina.dakimakura, shina.amountdakimakura, limit.dakimaprice, limit.dakimalimit) + "\n"
                            + goods4(shina.goods, shina.amountgoods, limit.goodsprice, limit.goodslimit);

            }
            //5
            if (analytic >= 90)
            {
                saku.text = book4(shina.book, limit.bookprice, limit.booklimit) + "\n"
         + tape4(shina.tape, shina.amounttape, limit.tapeprice, limit.tapelimit) + "\n"
         + dakima4(shina.dakimakura, shina.amountdakimakura, limit.dakimaprice, limit.dakimalimit) + "\n"
         + goods4(shina.goods, shina.amountgoods, limit.goodsprice, limit.goodslimit)
         + "\n列人数　　" + (int)shina.guests;

            }


            //完売表示
            if (shina.dakimakura)
            {
                if (shina.amountdakimakura >= 1)
                {
                    dakimaprice.text = limit.dakimaprice + "円";
                    dakimalimit.text = limit.dakimalimit + "限";
                    dakima.interactable = true;

                }

                if (shina.amountdakimakura < 1)
                {
                    dakimaprice.text = "";
                    dakimalimit.text = "完売";
                    dakima.interactable = false;
                }
            }
            else
            {            
                    dakimalimit.text = "なし";
                    dakimaprice.text = "";
                    dakima.interactable = false;
            }

            
            if (shina.tape)
            {
                if (shina.amounttape >=1)
                {
                    tapeprice.text = limit.tapeprice + "円";
                    tapelimit.text = limit.tapelimit + "限";
                    tape.interactable = true;
                }

                if (shina.amounttape < 1)
                {
                    tapelimit.text = "完売";
                    tapeprice.text = "";
                    tape.interactable = false;
                }
            }
            else
            {
                tapeprice.text = "";
                tapelimit.text = "なし";
                tape.interactable = false;
            }
            if (shina.goods)
            {
                if (shina.amountgoods >= 1)
                {
                    goodsprice.text = limit.goodsprice + "円";
                    goodslimit.text = limit.goodslimit + "限";
                    goods.interactable = true;
                }
                if (shina.amountgoods < 1)
                {
                    goodslimit.text = "完売";
                    goodsprice.text = "";
                    goods.interactable = false;
                }
            }
            else
            {
                goodslimit.text = "なし";
                goodsprice.text = "";
                goods.interactable = false;
            }
            if (shina.book >= 1)
            {
                booksprice.text = limit.bookprice + "円";
                bookslimit.text = limit.booklimit + "限";
                books.interactable = true;
            }
            if (shina.book < 1)
            {
                bookslimit.text = "完売";
                booksprice.text = "";
                books.interactable = false;

            }

        }
	}
    void can()
    {
        show = true;
    }
    void cannot()
    {
        show = false;

    }
    string book1(float book)
    {
        if (book > 1)
        {
            return "あり";
        }
        else
        {
            return "なし";
        }
    }
    string tape1(bool tape)
    {
        string n;
        if (tape)
        {
            n = "タペストリー　あり";
            return n;
        }
        else
        {
            n = "タペストリー　なし";
            return n;
        }
    }
    string dakima1(bool dakima)
    {
        string n;
        if (dakima)
        {
            n = "抱き枕カバー　あり";
            return n;
        }
        else
        {
            n = "抱き枕カバー　なし";
            return n;
        }
    }
    string goods1(bool goods)
    {
        string n;
        if (goods)
        {
            n = "グッズセット　あり";
            return n;
        }
        else
        {
            n = "グッズセット　なし";
            return n;
        }
    }
    string tape3(bool tape, float amtape)
    {
        if (tape)
        {
            if (amtape > 1)
                return "タペストリー残り  " + (int)amtape;
            else
                return "タペストリー完売";

        }
        else
            return "タペストリーなし";
    }
    string dakima3(bool dakima, float amdakima)
    {
        if (dakima)
        {
            if (amdakima > 1)
                return "抱き枕カバー残り  " + (int)amdakima;
            else
                return "抱き枕カバー完売";
        }
        else
            return "抱き枕カバーはなし";
    }
    string goods3(bool goods, float amgoods)
    {
        if (goods)
        {
            if (amgoods > 1)
                return "グッズセット残り  " + (int)amgoods;
            else
                return "グッズセット完売";
        }
        else
            return "グッズセットなし";
    }
    string book3(float ambook)
    {
        if (ambook > 1)
        {
            return "新刊残り　 " + (int)ambook;
        }
        else
            return "新刊完売";
    }
    string tape4(bool tape, float amtape, float price, float limit)
    {
        if (tape)
        {
            if (amtape > 1)
                return "タペストリー残り  " + (int)amtape + "       単価　" + price + "円 限定数  " + limit;
            else
                return "タペストリー完売";

        }
        else
            return "タペストリーなし";
    }
    string dakima4(bool dakima, float amdakima, float price, float limit)
    {
        if (dakima)
        {
            if (amdakima > 1)
                return "抱き枕カバー残り  " + (int)amdakima + "     単価　" + price + "円 限定数  " + limit;
            else
                return "抱き枕カバー完売";
        }
        else
            return "抱き枕カバーなし";
    }
    string goods4(bool goods, float amgoods, float price, float limit)
    {
        if (goods)
        {
            if (amgoods > 1)
                return "グッズセット残り  " + (int)amgoods + "      単価　" + price + "円 限定数  " + limit;
            else
                return "グッズセット完売";
        }
        else
            return "グッズセットなし";
    }
    string book4(float ambook, float price, float limit)
    {
        if (ambook > 1)
        {
            return "新刊残り　 " + (int)ambook + "    単価　" + price + "円 限定数  " + limit;
        }
        else
            return "新刊完売";
    }
}
