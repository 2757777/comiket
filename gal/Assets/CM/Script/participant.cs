using UnityEngine;
using System.Collections;

public class participant : MonoBehaviour
{

    protected Animator animator;
    private float directionX = 0f;
    private float directionY = 0f;
    private bool walking = false;
    private float speed = 1f;
    public float h = 0;
    public float  i=5f;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (animator)
        {
            if (i >= 2)
            {
                i = 0;
                 h = Random.Range(0, 4);
              }
            i += Time.deltaTime;
                walking = true;
                if (h == 0)
                {
                    directionX = 1f;
                    directionY = 0f;
                }
                else if (h ==1)
                {
                    directionX = -1f;
                    directionY = 0f;
                }
                else if (h == 2)
                {
                    directionX = 0f;
                    directionY = 1f;
                }
                else if (h ==3)
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
                    transform.Translate(new Vector3(directionX, directionY, 0) * Time.deltaTime * 0.5f * speed);
                }
                animator.SetFloat("DirectionX", directionX);
                animator.SetFloat("DirectionY", directionY);
                animator.SetBool("Walking", walking);
            
        }
    }
}