using UnityEngine;
using System.Collections;

public class changeuriko : MonoBehaviour {
    //A-block
    public Sprite a, b, c, d, e, f, g,h;
    public Sprite ar, br, cr, dr, er, fr, gr, hr;
    public Sprite al, bl, cl, dl, el, fl, gl, hl;
	// Use this for initialization
	void Start () {
        //A-block
        if (gameObject.transform.parent.name == "A")
        {
            Ablock();
        }
        //right
        if (gameObject.transform.parent.name == "right")
        {
            right();
        }
        //left
        if (gameObject.transform.parent.name == "left")
        {
            left();
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void Ablock()
    {
        int n = Random.Range(0, 8);
        switch (n)
        {
            case 0:
                gameObject.GetComponent<SpriteRenderer>().sprite = a;
                break;
            case 1:
                gameObject.GetComponent<SpriteRenderer>().sprite = b;
                break;
            case 2:
                gameObject.GetComponent<SpriteRenderer>().sprite = c;
                break;
            case 3:
                gameObject.GetComponent<SpriteRenderer>().sprite = d;
                break;
            case 4:
                gameObject.GetComponent<SpriteRenderer>().sprite = e;
                break;
            case 5:
                gameObject.GetComponent<SpriteRenderer>().sprite = f;
                break;
            case 6:
                gameObject.GetComponent<SpriteRenderer>().sprite = g;
                break;
            case 7:
                gameObject.GetComponent<SpriteRenderer>().sprite = h;
                break;

        }
    }

    void right()
    {
        int n = Random.Range(0, 8);
        switch (n)
        {
            case 0:
                gameObject.GetComponent<SpriteRenderer>().sprite = ar;
                break;
            case 1:
                gameObject.GetComponent<SpriteRenderer>().sprite = br;
                break;
            case 2:
                gameObject.GetComponent<SpriteRenderer>().sprite = cr;
                break;
            case 3:
                gameObject.GetComponent<SpriteRenderer>().sprite = dr;
                break;
            case 4:
                gameObject.GetComponent<SpriteRenderer>().sprite = er;
                break;
            case 5:
                gameObject.GetComponent<SpriteRenderer>().sprite = fr;
                break;
            case 6:
                gameObject.GetComponent<SpriteRenderer>().sprite = gr;
                break;
            case 7:
                gameObject.GetComponent<SpriteRenderer>().sprite = hr;
                break;

        }
    }
    void left()
    {
        int n = Random.Range(0, 8);
        switch (n)
        {
            case 0:
                gameObject.GetComponent<SpriteRenderer>().sprite = al;
                break;
            case 1:
                gameObject.GetComponent<SpriteRenderer>().sprite = bl;
                break;
            case 2:
                gameObject.GetComponent<SpriteRenderer>().sprite = cl;
                break;
            case 3:
                gameObject.GetComponent<SpriteRenderer>().sprite = dl;
                break;
            case 4:
                gameObject.GetComponent<SpriteRenderer>().sprite = el;
                break;
            case 5:
                gameObject.GetComponent<SpriteRenderer>().sprite = fl;
                break;
            case 6:
                gameObject.GetComponent<SpriteRenderer>().sprite = gl;
                break;
            case 7:
                gameObject.GetComponent<SpriteRenderer>().sprite = hl;
                break;

        }
    }
}
