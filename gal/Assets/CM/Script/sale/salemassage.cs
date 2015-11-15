using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class salemassage : MonoBehaviour {
    public string Circlename, kind;
    public int salemoney;
    public GameObject goods;
    public Button salebutton;
    public playerproperty pro;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void show()
    {
        GetComponent<Text>().text = Circlename + "さんの" + kind + "ですね～\n" + salemoney + "円で買い取りしますので、いかがですか？";
        salebutton.GetComponent<Button>().interactable = true;
    }
    void sale()
    {
        pro.money += salemoney;
        Destroy(goods);
        GetComponent<Text>().text = "";
    }
}
