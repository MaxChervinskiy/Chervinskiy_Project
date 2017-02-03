using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

   private PlayerStats player;
    [SerializeField]
    private Slider healthBar;
    void Start () {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        if (player == null)
            Debug.LogError("player is null");
	}
	
	void Update () {

        healthBar.value = player.Health;
	}
}
