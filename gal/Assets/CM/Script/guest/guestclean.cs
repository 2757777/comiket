using UnityEngine;
using System.Collections;

public class guestclean : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("player").transform.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 p = player.transform.position;
        if(//远离玩家
            transform.position.x-2.5f>p.x||transform.position.x+2.5f<p.x||
            transform.position.y - 2.5f > p.y || transform.position.y + 2.5f < p.y||
            //超出范围
            transform.position.x < -3.385 || transform.position.y > 1.5 ||
            transform.position.x > 20.34 || transform.position.y < -8.72)
        {
            Destroy(gameObject);
            player.GetComponent<makeguest>().gusets--;

        }
	}
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "toilet" || other.tag == "desk" || other.tag == "saku")
        {
            Destroy(gameObject);
            player.GetComponent<makeguest>().gusets--;
        }

    }

}
