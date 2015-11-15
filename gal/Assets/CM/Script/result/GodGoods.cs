using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GodGoods : MonoBehaviour {
    public GameObject shima;
    public string godname;
    public bool tmp;
    public float times;
	// Use this for initialization
	void Start () {
        tmp = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (tmp&&times<2)
        {
            int n = Random.Range(0, 111);
            gameObject.GetComponent<Text>().text = shima.transform.GetChild(n).name;
            times += Time.deltaTime * 1;
        }
        if (times>=2&&tmp)
        {
                 decide();
                 tmp=false;
        }
      //  t += Time.deltaTime * 4f;
	}
    void decide()
    {
        int n = Random.Range(0, 111);
        gameObject.GetComponent<Text>().text = shima.transform.GetChild(n).name;
        godname = shima.transform.GetChild(n).name;
    }
    void re()
    {
        tmp = true;
        times = 0;
    }
}
