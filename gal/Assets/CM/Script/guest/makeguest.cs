using UnityEngine;
using System.Collections;

public class makeguest : MonoBehaviour {
    public int gusets = 0;
    public GameObject guest1, guest2, guest3, guest4, guest5, guest6, guest7, guest8;
    GameObject gusetpro;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gusets < 20)
        {
            int c = Random.Range(0, 4);
            int n = Random.Range(0, 8);
            switch (n) { 
                case 0:
             gusetpro = (GameObject)Instantiate(guest1);
            break;
                case 1:
             gusetpro = (GameObject)Instantiate(guest2);
            break;
                case 2:
            gusetpro = (GameObject)Instantiate(guest3);
            break;
                case 3:
            gusetpro = (GameObject)Instantiate(guest4);
            break;
                case 4:
            gusetpro = (GameObject)Instantiate(guest5);
            break;
                case 5:
            gusetpro = (GameObject)Instantiate(guest6);
            break;
                case 6:
            gusetpro = (GameObject)Instantiate(guest7);
            break;
                case 7:
            gusetpro = (GameObject)Instantiate(guest8);
            break;

        }
            switch (c)
            {
                case 0:
                    gusetpro.transform.position=new Vector2(transform.position.x+Random.Range(0f,1.5f),transform.position.y+2f);
                    gusets++;
                    break;
            case 1:
                    gusetpro.transform.position = new Vector2(transform.position.x + 2f, transform.position.y + Random.Range(0f, 1.5f));
                     gusets++;
                    break;
                case 2:
                    gusetpro.transform.position = new Vector2(transform.position.x + Random.Range(0f, 1.5f), transform.position.y - 2f);
                                        gusets++;
                    break;
                case 3:
                    gusetpro.transform.position = new Vector2(transform.position.x -2f, transform.position.y + Random.Range(0f, 1.5f));
                    gusets++;
                    break;

            }
            gusetpro.GetComponent<guestclean>().enabled = true;
            gusetpro.GetComponent<participant>().enabled = true;
            
        }
	}
}
