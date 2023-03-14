using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEnermy : Enermy
{
    private Vector2 slopShootRobot = new Vector2(-1, 0.5f);
    private Vector3 rotateGunOfRobot = new Vector3(75, -60, -300);
    public RobotEnermy() : base() { }
    public override void Initialize(double baseHp, double baseDamage, Vector2 endpoint, float timeToAttack, Vector2 slopeShoot)
    {
        base.Initialize(baseHp, baseDamage, endpoint, timeToAttack, slopeShoot);
    }
    // Start is called before the first frame update
    public override void Start()
    {
        Initialize(10, 10, new Vector2(-4f, -4f), 10f,slopShootRobot);
        base.Start();
        childObject.transform.Rotate(rotateGunOfRobot);
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }
    public override void Die()
    {
        base.Die();
        Common.money += 1500;
    }
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
