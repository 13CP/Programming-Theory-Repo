using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected float speed = 50.0f;
    protected Rigidbody enemyRb;
    protected GameObject playerGoal;

    //ABSTRACTION
    public virtual void Attack()
    {
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);
    }


    // Start is called before the first frame update
    public void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Target");
        

    }

    // Update is called once per frame
    public virtual void Update()
    {
     Attack();
    }

    

    public void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Target")
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        } 


    }

    private void OnMouseDown()
    {
            Destroy(gameObject);
               
    }

}
