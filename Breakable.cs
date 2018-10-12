using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour {

    public int resistance = 4;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (resistance > 0) {
            resistance--;
            addaptOpacity();

            if (resistance == 0) {
                gameObject.SetActive(false);
            }

        }
    }

    private void addaptOpacity()
    {
        Color tmp = gameObject.GetComponent<Renderer>().material.color;
        tmp.a = 0.25f * resistance;
        gameObject.GetComponent<Renderer>().material.color = tmp;
    }

    public int getResistance()
    {
        return resistance;
    }
}
