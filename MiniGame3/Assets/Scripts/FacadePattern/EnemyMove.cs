/*
     * (Santiago Garcia II)
     * (EnemyDirection.cs)
     * (Assignment11)
     * (has the fuctions/methods for moving the enemy towards the player )
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed ;
    private Transform target;
    

    
    
    
   

    public void FindPlayer()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void MoveToPlayer()
    {
        

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
   
}
