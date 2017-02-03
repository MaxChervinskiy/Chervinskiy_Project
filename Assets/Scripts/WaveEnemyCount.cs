using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveEnemyCount : MonoBehaviour {

    [SerializeField]
    private Text Wave;
    [SerializeField]
    private Text enemyCount;
    [SerializeField]
    private Text Scores;

    private Spawner spawner;
    // Use this for initialization
    void Start () {
        spawner = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Spawner>();
        changeText();
	}
	
	// Update is called once per frame
	void Update () {
        changeText();
    }

    void changeText() {
        Wave.text = spawner.currentWaveNumber.ToString();
        enemyCount.text = spawner.currentEnemycount.ToString();
        Scores.text = spawner.Score.ToString();
    }
}
