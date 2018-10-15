using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour {

    public float speed = 15;
    public string axis = "VerticalLeft";

    private Rigidbody2D rb2d;

    void Awake () {
        
    }

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {

	}

    // It's called at a fixed rate
    // Add here physics calculations
    void FixedUpdate () {
        //Debug.Log(vertical);
        if (GameManager.sharedInstance.gameStarted)
        {
            float vertical = Input.GetAxisRaw(axis);
            Vector2 movement = new Vector2(0, vertical);

            rb2d.velocity = movement * speed;
        }
    }
}
