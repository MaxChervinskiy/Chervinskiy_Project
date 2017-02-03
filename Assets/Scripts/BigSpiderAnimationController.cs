using UnityEngine;
using System.Collections;

public class BigSpiderAnimationController : MonoBehaviour {

    AnimationClip walk;
	void Start () {
        GetComponent<Animation>().Play("Walk");   
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
