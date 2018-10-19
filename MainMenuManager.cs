using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {
    public void LoadPongRoyale() {
        SceneManager.LoadScene("PongRoyale");
    }

    public void LoadArkanoid() {
        SceneManager.LoadScene("Arkanoid");
    }
}
