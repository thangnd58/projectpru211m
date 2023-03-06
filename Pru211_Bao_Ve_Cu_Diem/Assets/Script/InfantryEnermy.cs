using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfantryEnermy : Enermy
{
    //public InfantryEnermy(int level) : base(level)
    //{
    //}
    private Vector2 slopShootInfantry = new Vector2(-1, 0.5f);
    public InfantryEnermy() : base(){ }
    public override void Initialize(double baseHp, double baseDamage, Vector2 endpoint, float timeToAttack, Vector2 slopeShoot)
    {
        base.Initialize(baseHp, baseDamage, endpoint, timeToAttack,slopeShoot);
    }
    public override void Start()
    {
        
        Initialize(10, 5,new Vector2(-6f,-4.13f),5f,slopShootInfantry);
        base.Start();
        
    }
    public override void Update()
    {
        base.Update();
    }
    public override void Die()
    {
        base.Die();
    }
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
