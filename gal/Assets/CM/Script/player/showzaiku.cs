using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showzaiku : MonoBehaviour {
    //品text
    public GameObject shinana;
    playerproperty pro;
   // float analytic;
    public Canvas processioncheck, procession,joy;
    public int guest;
    public  deskproperty deskpro;
    public Button exit;
    public PlayerControl con;
    public Remaining rema;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //サークル完売の場合
        if (deskpro != null)
        {
            if (deskpro.amountdakimakura < 1 && deskpro.amountgoods < 1 && deskpro.amounttape < 1 && deskpro.book < 1)
            {
                procession.enabled = false;
                con.enabled = true;
                rema.SendMessage("exitprocession");
                joy.enabled = true;
            }
        }
	}
    void OnTriggerEnter2D(Collider2D other)
        {

            if (other.gameObject.tag == "desk")
            {
                processioncheck.enabled = true;
               //deskproperty shina = other.gameObject.GetComponent<deskproperty>();
              //  deskprice limit = other.gameObject.GetComponent<deskprice>();
             //   Text saku = shinana.GetComponent<Text>();
              deskshowgoods show= other.gameObject.GetComponent<deskshowgoods>();
              deskpro = other.gameObject.GetComponent<deskproperty>();
                show.SendMessage("can");
                
               // guest = (int)shina.guests;
                
               /* //1
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
                    saku.text =book3(shina.book)+ "\n"
                        +tape3(shina.tape, shina.amounttape) +"\n" 
                        + dakima3(shina.dakimakura, shina.amountdakimakura) + "\n" 
                        + goods3(shina.goods, shina.amountgoods);
                }
                //4
                if (analytic >= 70 && analytic < 90)
                {
                    saku.text = book4(shina.book, limit.bookprice, limit.booklimit) + "\n"
                                + tape4(shina.tape, shina.amounttape,limit.tapeprice,limit.tapelimit) +"\n" 
                                + dakima4(shina.dakimakura, shina.amountdakimakura,limit.dakimaprice,limit.dakimalimit) + "\n" 
                                + goods4(shina.goods, shina.amountgoods,limit.goodsprice,limit.goodslimit);

                }
                //5
                if (analytic >= 90)
                {
                    saku.text = book4(shina.book,limit.bookprice,limit.booklimit) + "\n"
             + tape4(shina.tape, shina.amounttape, limit.tapeprice, limit.tapelimit) + "\n"
             + dakima4(shina.dakimakura, shina.amountdakimakura, limit.dakimaprice, limit.dakimalimit) + "\n"
             + goods4(shina.goods, shina.amountgoods, limit.goodsprice, limit.goodslimit)
             + "\n列人数　　" +(int)shina.guests;

                }*/
            }

        }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "desk")
        {

            processioncheck.enabled = false;
            deskshowgoods show = other.gameObject.GetComponent<deskshowgoods>();
            show.SendMessage("cannot");
            shinana.GetComponent<Text>().text = "";


        }

    }
    void dakimamin()
    {
        deskpro.amountdakimakura--;
    }
    void tapemin()
    {
        deskpro.amounttape--;
    }
    void goodsmin()
    {
        deskpro.amountgoods--;
    }
    void bookmin()
    {
        deskpro.book--;
    }

  /*          string book1(float book)
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
                if(tape){
                     n = "タペストリー　あり";
                    return n;
                }else{
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
            string book3(float ambook) {
                if (ambook > 1)
                {
                    return "新刊残り　 " + (int)ambook;
                }
                else
                    return "新刊完売";
            }

            string tape4(bool tape, float amtape,float price,float limit)
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
                        return "抱き枕カバーなし";
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
                    return "新刊完売しました";
            }
   */
}
