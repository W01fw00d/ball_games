using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour {

    public int resistance = 4;
    private int maxResistance;

    // Use this for initialization
    void Start () {
        maxResistance = resistance;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (resistance > 0) {
            resistance--;
            if (resistance == 0) {
                gameObject.SetActive(false);
            } else {
                addaptOpacity();
            }

        }
    }

    private void addaptOpacity()
    {
        Color tmp = gameObject.GetComponent<Renderer>().material.color;
        tmp.a = (1.0f / maxResistance) * resistance;
        gameObject.GetComponent<Renderer>().material.color = tmp;
    }

    public int getResistance()
    {
        return resistance;
    }
}
