using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnTrigger : MonoBehaviour {

    public GameObject targetObject;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == targetObject.tag)
        {
            Invoke("respawn", 2.0f);
            GetComponent<AudioSource>().Play();
        }
    }

    private void respawn()
    {
        targetObject.GetComponent<Spawnable>().respawn();
    }
}
