using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

    public float speed = 15;
    
    private Rigidbody2D rb2d;
    
    private int mod;
    
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "RacketLeft") {
            mod = 1;
        } else if (collision.gameObject.name == "RacketRight") {
            mod = -1;
        }
        
        float y = hitFactor(
            transform.position,
            collision.transform.position,
            collision.collider.bounds.size.y
        );
            
        Vector2 direction = new Vector2(mod, y).normalized;
        rb2d.velocity = direction * speed;
    }
    
    float hitFactor(Vector2 ballPosition, Vector2 racketPosition, float racketHeight) {
        return (ballPosition.y - racketPosition.y) / racketHeight;
    }
}
