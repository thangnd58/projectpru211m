using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEnermy : Enermy
{
    public RobotEnermy() : base() { }
    public override void Initialize(double baseHp, double baseDamage, Vector2 endpoint, float timeToAttack)
    {
        base.Initialize(baseHp, baseDamage, endpoint, timeToAttack);
    }
    // Start is called before the first frame update
    public override void Start()
    {
        Initialize(10, 10, new Vector2(-5f, -4f), 10f);
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }
}
