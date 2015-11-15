using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class flash : MonoBehaviour
{
    int n = 0;
    public Scrollbar bar;
    float s = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bar.size <= 0.2)
        {
            if (s > 0.5)
            {
                if(n%2==0)
                GetComponent<Image>().enabled = false;
                else
                GetComponent<Image>().enabled = true;

                n++;
                s = 0;
            }
            s += Time.deltaTime;
        }
        else
            GetComponent<Image>().enabled = true;

    }
}
