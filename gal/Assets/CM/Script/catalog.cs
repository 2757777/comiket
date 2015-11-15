using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class catalog : MonoBehaviour
{
    float n = 0;
    public GameObject news;
    public PlayerControl player;
    public Canvas joystick;


	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Button>().onClick.AddListener(onclick);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void onclick()
    {
        n++;
        if (n % 2 == 0)
        {
            news.GetComponent<Canvas>().enabled = false;
            player.enabled = true;
            joystick.enabled = true;        
        }
        else
        {
            news.GetComponent<Canvas>().enabled = true;
            player.enabled = false;
            joystick.enabled = false;
        }
    }
    void nplus()
    {
        n++;
    }
}
