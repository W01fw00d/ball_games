using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour {

    public float speed = 5;
    public string axis = "Horizontal";

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //if (GameManager.sharedInstance.gameStarted)
        //{
            float input = Input.GetAxisRaw(axis);
            Vector2 movement = Vector2.right * input * speed;

            rb2d.velocity = movement * speed;
            //gameObject.transform.localScale = (input > 0) ? input : 1;
        //}
    }
}
