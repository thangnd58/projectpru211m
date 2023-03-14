using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnermy : Enermy
{
    private Vector2 slopShootTank = new Vector2(-1, 1);
    private Vector3 rotateGunOfTank = new Vector3(10, -75, -300);
    public TankEnermy() : base() { }
    public override void Initialize(double baseHp, double baseDamage, Vector2 endpoint, float timeToAttack, Vector2 slopeShoot)
    {
        base.Initialize(baseHp, baseDamage, endpoint, timeToAttack, slopeShoot);
    }
    // Start is called before the first frame update
    public override void Start()
    {
        Initialize(10, 10, new Vector2(-5f, -4f), 12f,slopShootTank);
        base.Start();
        childObject.transform.Rotate(rotateGunOfTank);
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }
    public override void Die()
    {
        base.Die();
        Common.money += 2500;
    }
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
