using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControl : MonoBehaviour {

    public /*protected*/ Animator animator;
    public GameObject sakuru;
    
    public float directionX = 0f;
    public float directionY = 0f;
    public bool walking = false;
    public float speed;
    public float h;
    public float v;

    public GameObject nowsakuru;
    void Start()
    {
        animator = GetComponent<Animator>();
        playerproperty pro = this.gameObject.GetComponent<playerproperty>();
        speed = pro.speed/50;
        
    }

    void FixedUpdate()
    {
        if (animator)
        {
            h = CrossPlatformInputManager.GetAxisRaw("Horizontal");
            v = CrossPlatformInputManager.GetAxisRaw("Vertical");
            walking = true;
            if (h > 0&&h>v)
            {
                directionX = 1f;
                directionY = 0f;
            }
            else if (h < 0&&h<v)
            {
                directionX = -1f;
                directionY = 0f;
            }
            else if (v > 0&&v>h)
            {
                directionX = 0f;
                directionY = 1f;
            }
            else if (v > 0 && v == h)
            {
                directionX = 0f;
                directionY = 1f;
            }

            else if (v < 0&&v<h)
            {
                directionX = 0f;
                directionY = -1f;
            }
            else if (v < 0 && v == h)
            {
                directionX = 0f;
                directionY = -1f;
            }

            else
            {
                walking = false;
            }
            if (walking)
            {
                transform.Translate(new Vector3(directionX, directionY, 0) * Time.deltaTime * 0.5f*speed);

            }
            animator.SetFloat("DirectionX", directionX);
            animator.SetFloat("DirectionY", directionY);
            animator.SetBool("Walking", walking);
        }
    }
    //撞到参加者速度变慢
    	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.tag == "sanka")
		{
            speed -=0.2f;
  		}
        if (other.gameObject.tag == "desk")
        {
            Text saku = sakuru.GetComponent<Text>();
            saku.text = other.gameObject.name;
            nowsakuru = other.gameObject;
         }

           
	}
        void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.tag == "sanka")
            {
                speed +=0.2f;
            }
            if (other.gameObject.tag == "desk")
            {
                Text saku = sakuru.GetComponent<Text>();
                saku.text = "";
                other.gameObject.GetComponent<Rigidbody2D>().WakeUp();
                nowsakuru = null;
            }
            
        }
 
}