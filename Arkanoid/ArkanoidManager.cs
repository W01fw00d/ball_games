using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArkanoidManager : MonoBehaviour {

    public Image life1, life2, life3;
    public Text gameOverTxt, gameWinnedTxt, durationTxt;

    public bool isTheGameEnded = false;

    private Spawnable ball;

    private float startTime = 0;

	void Start () {
        ball = GameObject.Find("Ball").GetComponent<Spawnable>();
        gameOverTxt.enabled = false;
        gameWinnedTxt.enabled = false;
    }
	
	void Update () {
        if (!isTheGameEnded) {
            if (ball.lifes == 0)
            {
                isTheGameEnded = true;
                gameOverTxt.enabled = true;
                Invoke("goToMainMenu", 2.0f);

            } else {
                life3.enabled = ball.lifes >= 3;
                life2.enabled = ball.lifes >= 2;
                life1.enabled = ball.lifes >= 1;
            }

            GameObject[] bricks = GameObject.FindGameObjectsWithTag("Brick");
            if (bricks.Length == 0) {
                Debug.Log("NO BRICKS!");
                isTheGameEnded = true;
                gameWinnedTxt.enabled = true;
                Invoke("goToMainMenu", 2.0f);
            }

            startTime += Time.deltaTime;
            Debug.Log(startTime);
            durationTxt.text = "Tiempo: " + startTime.ToString("0.00");
        }
    }

    private void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
