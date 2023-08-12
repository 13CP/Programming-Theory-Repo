using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BlueEnemy : Enemy
{
    // ENCAPSULATION
    public static Vector3 scaleChange { get; private set;}
    
    //POLYMORPHISM
    public override void Attack()
    { 
        speed = -25f;
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection *speed * Time.deltaTime); 
    }

    // Update is called once per frame
    public override void Update()
    {
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
        transform.localScale += scaleChange * Time.deltaTime;
        Attack();
    }
}