using UnityEngine;
using System.Collections;

public class KeyboardRestart : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
        if (Input.GetKey(KeyCode.Space))
            GetComponent<RestartGame>().restartGame();
    }
}
