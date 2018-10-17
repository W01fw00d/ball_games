using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

//using UnityEngine.SceneManagement.SceneManager;

public class MainMenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadPong() {
        SceneManager.LoadScene("Pong");
    }

    public void LoadArkanoid() {
        SceneManager.LoadScene("Arkanoid");
    }
}
