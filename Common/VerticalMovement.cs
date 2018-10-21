using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour {

    public float speed = 15;
    public string axis = "VerticalLeft";

    private Rigidbody2D rb2d;

	void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate()
    {
        if (GameManager.sharedInstance.gameStarted) {
            float vertical = Input.GetAxisRaw(axis);
            Vector2 movement = new Vector2(0, vertical);

            rb2d.velocity = movement * speed;
        }
    }
}
