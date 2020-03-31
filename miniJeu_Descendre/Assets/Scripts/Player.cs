using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0;
    public float MaxSpeed = 4;
    public Rigidbody2D mybody;
    public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mybody = this.gameObject.GetComponent<Rigidbody2D>();
        myAnimator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        
    }
    void PlayerMove()
    {
        var x = Input.GetAxis("Horizontal");
        //Debug.Log(x);
        if (x > 0)
        {
            speed = MaxSpeed;
            myAnimator.SetBool("walk", true);
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else if(x < 0)
        {
            speed = -MaxSpeed;
            myAnimator.SetBool("walk", true);
            this.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            speed = 0;
            myAnimator.SetBool("walk", false);
        }
        mybody.AddForce(new Vector2(speed, 0));
    }
}
