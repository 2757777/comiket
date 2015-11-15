using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class playerproperty : MonoBehaviour {
    public float speed;
    public float knowledge;
    public float analytic;
    public float fortitude;
    public float sociable;
    public int money;
    public Text showmoney,homeleverl,homemoney;
    public float Exp;
    public int level, distribution;
    public EnergyBar homeexp;
    
	// Use this for initialization
	/*void Awake () {
      property pro=GameObject.Find("property").GetComponent<property>();
      speed = pro.speed;
      knowledge = pro.knowledge;
      analytic = pro.analytic;
      fortitude = pro.fortitude;
      money = pro.money;
      Destroy(GameObject.Find("property"));

	}*/
    void Start()
    {
        homeleverl.text = "レベル　" + level;
        homeexp.valueCurrent = (int)Exp;
        showmoney.text = "軍資金 "+money+"円";
        homemoney.text = "軍資金 " + money + "円";
     //   Advertisement.Initialize("34203");

    }
    void refresh()
    {
        showmoney.text = "軍資金 " + money + "円";
        homemoney.text = "軍資金 " + money + "円";
        if (Exp > 99)
        {
            level++;
            Exp -= 100;
            distribution += 2;
        }
            if (level > 99)
        {
            level = 99;
            Exp = 99;
        }
        homeleverl.text = "レベル　"+level;
        homeexp.valueCurrent = (int)Exp;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
