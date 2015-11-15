using UnityEngine;
using System.Collections;
public class deskcollider : MonoBehaviour
{
   public Canvas jihanki;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
    public int GetRandomDirection(int nowDirectionIndex/*, float[] directions*/)
    {
        int newIndex;
        do
        {
            newIndex = Random.Range(0, 4);
        } while (newIndex == nowDirectionIndex);
        return newIndex;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "sanka")
        {
            sanka(other);
        }
        if (other.gameObject.name == "player"&&name=="jihanki")
        {
            player();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "player" && name == "jihanki")
        {
            jihanki.enabled = false;
        }
    }
    void sanka(Collider2D other)
    {
        participant btn = other.gameObject.GetComponent<participant>();

        int n = (int)btn.h;
        Vector3 ntr = other.gameObject.transform.position;
        switch (n)
        {
            case 0:
                ntr.x -= 0.1f;
                break;
            case 1:
                ntr.x += 0.1f;
                break;
            case 2:
                ntr.y -= 0.1f;
                break;
            case 3:
                ntr.y += 0.1f;
                break;

        }
        other.gameObject.transform.position = ntr;
        btn.h = GetRandomDirection(n);
        btn.i = 0f;
    }

    void player()
    {
        jihanki.enabled = true;
    }


}
