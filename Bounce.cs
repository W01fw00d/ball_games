using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    public float speed = 15;

    private Rigidbody2D rb2d;
    private int x;
    private bool hasObjectMoved = false;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasObjectMoved && GameManager.sharedInstance.gameStarted)
        {
            rb2d.velocity = Vector2.right * speed;
            hasObjectMoved = true;
        }
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

    private float getObjectY(Collision2D collision)
    {
        return hitFactor(
            transform.position,
            collision.transform.position,
            collision.collider.bounds.size.y
        );
    }

    private int getObjectX(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketLeft" || collision.gameObject.name == "WallLeft") {
            x = 1;
        }
        else if (collision.gameObject.name == "RacketRight" || collision.gameObject.name == "WallRight") {
            x = -1;
        }

        return x;
    }

    float hitFactor(Vector2 ballPosition, Vector2 racketPosition, float racketHeight)
    {
        return (ballPosition.y - racketPosition.y) / racketHeight;
    }
}
