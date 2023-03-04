using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.ScrollRect;

public  class Enermy : MonoBehaviour 
{
    public double Level { get; set; }
    public double Hp { get; set; }
    public double Damage { get; set; }
    public Vector2 EndPoint { get; set; }
    public float TimeToAttack { get; set; }
    private float elapsedTime = 0.0f;
    private Vector2 startingPosition;
    //public Enermy(int level)
    //{
    //    this.Level = level;
    //}
    public Enermy()
    {
        this.Level = 1;
    }
    public virtual void Initialize(double baseHp, double baseDamage, Vector2 endpoint, float timeToAttack )
    {
        
        Hp = baseHp * Math.Pow(1.2, Level);
        Damage = baseDamage * Math.Pow(1.2, Level);
        EndPoint = endpoint;
        TimeToAttack= timeToAttack;
    }
    public virtual void Attack()
    {

    }
    // Start is called before the first frame update
    public virtual void Start()
    {
        startingPosition=gameObject.transform.position;
    }
    public virtual void Shoot()
    {

    }
    // Update is called once per frame
    public virtual void Update()
    {

        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / TimeToAttack;
        transform.position = Vector2.Lerp(startingPosition, EndPoint, percentageComplete);
    } 
    public virtual void BeingAttacked(Double amount)
    {
        if (Hp > 0)
        {
            Hp-= amount;
        }
        else
        {
            Die();
        }
    }
    public virtual void Die()
    {
        Destroy(gameObject);
    }
    
}
