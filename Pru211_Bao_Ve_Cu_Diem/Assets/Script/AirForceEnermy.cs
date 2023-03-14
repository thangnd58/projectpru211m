using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirForceEnermy : Enermy
{
    private Vector2 slopShootAirForce = new Vector2(-1, -0.7f);
    private Vector3 rotateGunOfAirForce = new Vector3(-45, -60, 0);
    public AirForceEnermy() : base() { }
    public override void Initialize(double baseHp, double baseDamage, Vector2 endpoint, float timeToAttack, Vector2 slopeShoot)
    {
        base.Initialize(baseHp, baseDamage, endpoint, timeToAttack,slopeShoot);
    }
    // Start is called before the first frame update
    public override void Start()
    {
        Initialize(10, 10, new Vector2(-6f, 2.5f), 8f,slopShootAirForce);
        base.Start();
        childObject.transform.Rotate(rotateGunOfAirForce);
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }
    public override void Die()
    {
        base.Die();
        Common.money += 250;
    }
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
    public override void Shoot()
    {
        base.Shoot();
    }
}
