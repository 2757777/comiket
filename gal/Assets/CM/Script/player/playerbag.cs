using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerbag : MonoBehaviour {
    public GameObject dakima,tape,goods,books;
	// Use this for initialization
	void Start () {
       /* GameObject go = Instantiate(dakima) as GameObject;
        go.transform.SetParent(transform, false);
        go.AddComponent<BagButtonProperty>();*/

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void makedakima()
    {
        GameObject go = Instantiate(dakima) as GameObject;
        go.transform.SetParent(transform, false);
        go.AddComponent<BagButtonProperty>();
    }
    void maketape()
    {
        GameObject go = Instantiate(tape) as GameObject;
        go.transform.SetParent(transform, false);
        go.AddComponent<BagButtonProperty>();
    }
    void makegoods()
    {
        GameObject go = Instantiate(goods) as GameObject;
        go.transform.SetParent(transform, false);
        go.AddComponent<BagButtonProperty>();
    }
    void makebooks()
    {
        GameObject go = Instantiate(books) as GameObject;
        go.transform.SetParent(transform, false);
        go.AddComponent<BagButtonProperty>();
    }
}
