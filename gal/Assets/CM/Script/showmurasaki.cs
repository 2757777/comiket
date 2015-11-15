using UnityEngine;
using System.Collections;

public class showmurasaki : MonoBehaviour {
    public PlayerControl player;
    int n = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (player.walking&&n==1)
        {
            transform.position=new Vector2 (transform.position.x * -1,transform.position.y);
            n--;
        }
        if(player .walking==false&&n==0){
            transform.position=new Vector2 (transform.position.x * -1,transform.position.y);
            n++;

        }
        
	}
}
