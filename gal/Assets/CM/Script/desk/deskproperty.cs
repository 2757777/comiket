using UnityEngine;
using System.Collections;

public class deskproperty : MonoBehaviour {
    public float deskLevel;
    public float guests=0;
    public float cardinals;
    public float book;
    public bool dakimakura;
    public float amountdakimakura;
    public bool goods;
    public float amountgoods;
    public bool tape;
    public float amounttape;
    public float maxguest;
    bool dakimaguestminus=true;
    bool goodsguestminus = true;
    bool tapeguestminus = true;
    deskprice limit;
	// Use this for initialization
    void Awake()
    {
       // if (GetComponent<shimakind>().kabe)
        //{
            deskLevel = 0;
            //dakimakura
            int n = Random.Range(0, 2);
            if (n == 1)
            {
                dakimakura = true;
                n = Random.Range(1, 5);
                amountdakimakura = n * 100;
                deskLevel += (10 - n);
            }
            else amountdakimakura = -1f;
            //goods
            n = Random.Range(0, 2);
            if (n == 1)
            {
                goods = true;
                n = Random.Range(1, 11);
                amountgoods = n * 100;
                deskLevel += (22 - n);
            }
            else amountgoods = -1;
            //tape
            n = Random.Range(0, 2);
            if (n == 1)
            {
                tape = true;
                n = Random.Range(1, 8);
                amounttape = n * 100;
                deskLevel += (16 - n);
            }
            else amounttape = -1;
            //books
            n = Random.Range(3, 16);
            book = n * 100;
            deskLevel += (32 - n);

            maxguest = deskLevel * deskLevel / 2 * 0.6f;
        }

	//}
    void Start()
    {
        limit = gameObject.GetComponent<deskprice>();
        guests = cardinals;
        
    }
	// Update is called once per frame
	void Update () {
        if (guests < maxguest)
        {
            guests++;
        }
            //guests = Mathf.SmoothStep(n, maxguest, /*deskLevel * 1000 */ Time.deltaTime) + cardinals;
            guests -= guests/50*Time.deltaTime ;
        //抱枕下降
        if (dakimakura)
        {
            if (amountdakimakura >= 0)
            {
                amountdakimakura -= (deskLevel / 1000)+((limit.dakimalimit-1)*0.005f);
            }
            else
                if(dakimaguestminus)
            {
                maxguest *= 0.7f;
                dakimaguestminus = false;
            }
        }
        //goods下降
        if (goods)
        {

            if (amountgoods >= 0)
            {
                amountgoods -= (deskLevel / 2000) + ((limit.goodslimit-1) * 0.005f);
            }
            else
                if(goodsguestminus)
            {
                maxguest *= 0.9f;
                goodsguestminus = false;
            }
        }
        //本子下降
        if (book >= 0)
        {
            book -= (deskLevel / 2500) + ((limit.booklimit-1) * 0.005f);
        }
        else
        {
            guests = 0;
        }
        //挂画下降
        if (tape)
        {
            if (amounttape >= 0)
            {
                amounttape -= (deskLevel / 1500) + ((limit.tapelimit-1) * 0.005f);
            }
            else
                if(tapeguestminus)
            {
                maxguest *= 0.8f;
                tapeguestminus = false;

            }
        }
    
	}

}
