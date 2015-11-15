using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gointoilet : MonoBehaviour {
    public bool suru=false;
    public Canvas toilet;
    public Scrollbar bar;
    public GameObject player;
    PlayerControl playerctrl;

	// Use this for initialization
	void Start () {
        playerctrl = player.GetComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update () {
        if (suru)
        {

            if (bar.size < 1)
            {
                bar.size += 0.1f * Time.deltaTime;
                player.GetComponent<PlayerControl>().enabled = false;
                player.GetComponent<SpriteRenderer>().enabled = false;
                toilet.enabled = false;
            }
            if (bar.size >= 1)
            {
                player.GetComponent<PlayerControl>().enabled = true;
                player.GetComponent<SpriteRenderer>().enabled = true;
                player.transform.Translate(new Vector3(playerctrl.directionX, -3.7f, 0) * Time.deltaTime * 0.5f * playerctrl.speed);
                playerctrl.directionY = -1;
                suru = false;

            }
        }
	}
    void yes()
    {
        suru = true;
    }
    void no()
    {
        player.transform.Translate(new Vector3(playerctrl.directionX, -3.7f, 0) * Time.deltaTime * 0.5f * playerctrl.speed);
        playerctrl.directionY = -1;
    }
        void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
            toilet.enabled = true;
        }
        

    }
        void OnTriggerExit2D(Collider2D other)
        {
            if (other.name == "player")
            {
                toilet.enabled = false;
            }
        }
}
