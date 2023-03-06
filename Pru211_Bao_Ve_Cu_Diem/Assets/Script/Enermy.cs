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
    public Vector2 SlopeShoot { get; set; }
    public float TimeToAttack { get; set; }
    private float elapsedTime = 0.0f;
    private Vector2 startingPosition;
    public float  bulletSpeed = 12f;
    public Timer timer; 
    public bool canShoot=true;

    [SerializeField]
    public GameObject bulletEnermy;
    public Rigidbody2D rigidbody { get; set; }
    //public Enermy(int level)
    //{
    //    this.Level = level;
    //}
    public Enermy()
    {
        this.Level = 1;
    }
    public virtual void Initialize(double baseHp, double baseDamage, Vector2 endpoint, float timeToAttack, Vector2 slopeShoot )
    {
        
        Hp = baseHp * Math.Pow(1.2, Level);
        Damage = baseDamage * Math.Pow(1.2, Level);
        EndPoint = endpoint;
        TimeToAttack= timeToAttack;
        SlopeShoot= slopeShoot;
    }
    
    // Start is called before the first frame update
    public virtual void Start()
    {
        startingPosition=gameObject.transform.position;
        timer = GetComponent<Timer>();
        timer.Duration = 1;
        timer.run();
    }
    public virtual void Shoot()
    {
        GameObject bullet = Instantiate(bulletEnermy, EndPoint, Quaternion.identity);
        rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(SlopeShoot * bulletSpeed, ForceMode2D.Impulse);
    }
    public virtual void Attack()
    {

    }
    // Update is called once per frame
    public virtual void Update()
    {

        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / TimeToAttack;
        transform.position = Vector2.Lerp(startingPosition, EndPoint, percentageComplete);
        if (Vector2.Distance(gameObject.transform.position,EndPoint)<=0.1f)
        {

            //if (!canShoot)
            //{
            //    timer.run();
            //    canShoot = true;
            //}
            //else
            //{
            //    if (timer.Finished )
            //    {
            //        Shoot();
            //        canShoot = false;
            //    }
            //}
            if (timer.Finished)
            {
                Shoot();
                timer.run();
            }

        }
        
        

        
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
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")

        {
            Die();
            
        }
    }
}
