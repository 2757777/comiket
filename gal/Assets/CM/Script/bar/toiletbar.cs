using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toiletbar : MonoBehaviour
{
    Scrollbar hpbar;
    public Color col ;
    // Use this for initialization
	void Start () {
         hpbar = gameObject.GetComponent<Scrollbar>();
	}
	
	// Update is called once per frame
	void Update () {
        if (hpbar.size > 1) hpbar.size = 1;
        hpbar.size -= Time.deltaTime * 0.001f;
        col = Color.Lerp(Color.red, Color.green, hpbar.size);
        hpbar.targetGraphic.color = col;
    }
    void downtoilet()
    {
        hpbar.size -= Time.deltaTime *2;
    }

}
