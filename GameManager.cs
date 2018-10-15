using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance = null;
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

    // Use this for initialization
    void Start()
    {
        leftBreakable = leftWall.GetComponent<Breakable>();
        rightBreakable = rightWall.GetComponent<Breakable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (
            Mathf.Round(mainCamera.transform.position.x) == leftWonTitleCenterPosition ||
            Mathf.Round(mainCamera.transform.position.x) == rightWonTitleCenterPosition
        ) {
            fixedCamera = true;
        }

        if (
            gameStarted &&
            (
                leftBreakable.resistance == 0 ||
                rightBreakable.resistance == 0
            )
        ) {
            if (fixedCamera) {
                if (Mathf.Round(ball.transform.position.x) == 0 && mainCamera.transform.position.x == 0) {
                    fixedCamera = false;
                }
            } else {
                moveCamera();
            }
        }
    }

    private void moveCamera()
    {
        mainCamera.transform.position =
            new Vector3(ball.transform.position.x, 0, -10);
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
