using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPbar : MonoBehaviour {
    Scrollbar hpbar;
    public Color col;
    playerproperty pro;
    float fortitude;

   public GameObject player;
    // Use this for initialization
	void Start () {
        pro = player.GetComponent<playerproperty>();
         hpbar = gameObject.GetComponent<Scrollbar>();
         fortitude = (101-pro.fortitude)/10000;
	}
	
	// Update is called once per frame
	void Update () {
        hpbar.size -= Time.deltaTime * fortitude;
        col = Color.Lerp(Color.red, Color.green, hpbar.size);
        hpbar.targetGraphic.color = col;
    }
    void uphp()
    {
                hpbar.size += Time.deltaTime * fortitude*70000;
            

        }
    }

