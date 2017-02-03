using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Enemy))]
public class HitDamege : MonoBehaviour,IHittble {
    [SerializeField]
    Enemy en;
    private bool _isAlive = true;
    public AudioClip deathSound; // if(TIME) 

    public void Start() {
        en = GetComponent<Enemy>();
    }
    public void hit()
    {
        en.takeDamege();
        if (en.getHealth() <= 0)
        {
            _isAlive = false;
            en.die();
        }
    }
    
    void Update()
    {
        if ( _isAlive== false)
            Destroy(this);
    }


}
