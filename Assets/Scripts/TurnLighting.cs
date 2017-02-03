using UnityEngine;
using System.Collections;

public class TurnLighting : MonoBehaviour {
    [SerializeField]
    private GameObject lighting;
    private bool isTurnedOff = false;
	
	void Start () {
        lighting.GetComponent<Light>().intensity = 0f;
	}
    
    void Update() {
        if (Input.GetKeyDown("l")){
            if (isTurnedOff==false)
            {
                lighting.GetComponent<Light>().intensity = 5f;
                isTurnedOff = true;
            }
            else {
                lighting.GetComponent<Light>().intensity = 0f;
                isTurnedOff = false;
            }
        }
	
	}
}
