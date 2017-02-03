using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerStats:MonoBehaviour {
    public int Health = 100;
    private int oldHeals=100;

    public AudioClip scream;

    void Update() {
        if (oldHeals != Health) {
            oldHeals = Health;
            GetComponent<AudioSource>().PlayOneShot(scream);
        }

        if (Health <= 0)
            SceneManager.LoadScene("GameOwer");
    }
	
}
