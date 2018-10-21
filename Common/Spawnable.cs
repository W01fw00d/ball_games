using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnable : MonoBehaviour {

    public GameObject spawnPoint;
    public int speedAtSpawn = 7;
    public int lifes = 3;

    public void respawn()
    {
        lifes--;

            transform.position = spawnPoint.transform.position;
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 1) * speedAtSpawn;
            GetComponent<ArkanoidBounce>().speed = speedAtSpawn;

       
    }

}
