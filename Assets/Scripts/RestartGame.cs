﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

    public void restartGame() {
        SceneManager.LoadScene("Game");
       
    }
   
}
