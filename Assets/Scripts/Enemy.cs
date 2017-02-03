using UnityEngine;
using System.Collections;

public abstract class Enemy :MonoBehaviour, IEnemy  
{
    [SerializeField]
    protected int health =10;
    protected float speed =1;
    public bool isAlive = true;
    public abstract void attack();
    public abstract void takeDamege();
    public abstract int getHealth();
    public abstract void die();


    public Transform player;
    private float attackDistans=2;
    private float attackDelay = 0.5f;
    protected bool isAttack = false;
    public int getHelth() {
        return this.health;
    }

    public float getSpeed() {
        return this.speed;
    }

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        

    }

    protected void CheckAttack()
    {
        if (isAttackrange && !isAttack)
        {
            Invoke("attack", attackDelay);
            isAttack = true;
        }
    }

    protected bool isAttackrange
    {
        get
        {
            return Vector3.Distance(transform.position, player.position) < attackDistans;
        }
    }
}
