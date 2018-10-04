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
        
//        parentscriptclass myParent = transform.parent.GetComponent<parentscriptclass>();
//        myParent.speed
	}

	// Update is called once per frame
	void Update () {

	}

    // It's called at a fixed rate
    // Add here physics calculations
    void FixedUpdate () {
        float vertical = Input.GetAxisRaw(axis);
        Debug.Log(vertical);

        Vector2 movement = new Vector2(0, vertical);

//        rb2d.AddForce(movement * speed);
        rb2d.velocity = movement * speed;

//        float horizontal = Input.GetAxisRaw("Horizontal");
//        rb2d.rotation += horizontal; 
    }
}
