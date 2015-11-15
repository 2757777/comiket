using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class useallmoney : MonoBehaviour
{
    int allmoney;
    public pluslist list;
    // Use this for initialization
    void Start()
    {
        allmoney = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void plus()
    {
        allmoney += list.total;
        GetComponent<Text>().text = "今回使ったお金は" + allmoney + "円";
    }
}
