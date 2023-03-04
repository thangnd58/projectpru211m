using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirForceEnermy : Enermy
{
    public AirForceEnermy() : base() { }
    public override void Initialize(double baseHp, double baseDamage, Vector2 endpoint, float timeToAttack)
    {
        base.Initialize(baseHp, baseDamage, endpoint, timeToAttack);
    }
    // Start is called before the first frame update
    public override void Start()
    {
        Initialize(10, 10, new Vector2(-6f, 2.5f), 8f);
        base.Start();
    }

    // Update is called once per frame
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
