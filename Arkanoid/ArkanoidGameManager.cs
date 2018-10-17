using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArkanoidGameManager : MonoBehaviour
{
    public static ArkanoidGameManager sharedInstance = null;
    public bool gameStarted = false;

    public bool fixedCamera = true;

    public Text titleText;
    public GameObject startButton;

    public GameObject leftWall;
    public GameObject rightWall;
    private Breakable leftBreakable;
    private Breakable rightBreakable;

    public GameObject mainCamera;
    public GameObject ball;

    private int rightWonTitleCenterPosition = 62;
    private int leftWonTitleCenterPosition = -62;

    void Awake()
    {
        if (sharedInstance == null) {
            sharedInstance = this;
        }
    }

    public void StartGame()
    {
        gameStarted = true;
        titleText.enabled = false;
        startButton.SetActive(false);
    }

    void Start()
    {
        leftBreakable = leftWall.GetComponent<Breakable>();
        rightBreakable = rightWall.GetComponent<Breakable>();
    }

    void FixedUpdate()
    {
        if (!gameStarted && Input.GetKey(KeyCode.Return)) {
            StartGame();
        }

        if (Input.GetKey(KeyCode.Return)) {
            Application.Quit();
        }
    }
}
