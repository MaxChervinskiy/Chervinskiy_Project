using UnityEngine;
using System.Collections;

public class AttackScript : MonoBehaviour {
    public Transform AttackPoint;
    public AudioClip hit;

    public void PlayerAttack() {
      
        var hits = Physics.OverlapSphere(AttackPoint.position, 0.5f);
        foreach(var hitt in hits)
        {
            var hittbles = hitt.GetComponents(typeof(IHittble));
            if (hittbles == null)
                return;

            foreach (IHittble hittble in hittbles)
            {
                GetComponentInParent<AudioSource>().PlayOneShot(hit);
                hittble.hit();
            }
        }
    }
}
