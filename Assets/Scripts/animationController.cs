using UnityEngine;
using System.Collections;

public class animationController : MonoBehaviour {

    public AnimationClip AttackAnim;
    [SerializeField]
    private Animator animator;
   
    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        animator.SetBool("kick", false);
        if (Input.GetMouseButton(0)) {
            animator.SetBool("kick", true);
            //GetComponent<Animation>().Play(AttackAnim.name);

        }

    }
}
