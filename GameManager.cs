using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager sharedInstance = null;
    public bool gameStarted = false;

    public Text titleText;
    public GameObject startButton;

    void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
    }

    public void StartGame()
    {
        gameStarted = true;
        titleText.enabled = false;
        startButton.SetActive(false);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
