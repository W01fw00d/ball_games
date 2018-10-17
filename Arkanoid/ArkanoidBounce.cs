using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidBounce : MonoBehaviour
{
    public float speed = 15;

    private Rigidbody2D rb2d;
    private float x;
    private float y;
    //private bool hasObjectMoved = false;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //if (!hasObjectMoved && GameManager.sharedInstance.gameStarted) {
            //rb2d.velocity = Vector2.up * speed;
            //hasObjectMoved = true;
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb2d.velocity = getObjectVelocity(collision);
    }

    private Vector2 getObjectVelocity(Collision2D collision)
    {
        Vector2 direction = new Vector2(
            getObjectX(collision),
            getObjectY(collision)
        ).normalized;

        return direction * speed;
    }

    private float getObjectX(Collision2D collision)
    {
        if (
            collision.gameObject.name == "LeftWall"
        ) {
            x = 1;
        }
        else if (
            collision.gameObject.name == "RightWall"
        ) {
            x = -1;
        } else if (collision.gameObject.name == "Paddle") {
            x = hitFactor(
                transform.position,
                collision.transform.position,
                collision.collider.bounds.size.x
            );
        }

        return x;
    }

    private float getObjectY(Collision2D collision)
    {
        if (collision.gameObject.name == "TopWall" || collision.gameObject.tag == "Brick") {
            y = -1;
        } else if (collision.gameObject.name == "Paddle") { 
            y = 1;
        }

        return y;
    }

    private float hitFactor(Vector2 ballPosition, Vector2 racketPosition, float racketWidth)
    {
        return (ballPosition.x - racketPosition.x) / racketWidth;
    }
}
