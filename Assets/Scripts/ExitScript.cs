using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour {

    private void ExitGame()
    {
        Application.Quit();

    }
    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("GameOwer");
        }
    }
}
