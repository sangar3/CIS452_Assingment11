/*
     * (Santiago Garcia II)
     * (EnemyDirection.cs)
     * (Assignment11)
     * (has the fuctions/methods for directing the enemy towards the player )
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDirection : MonoBehaviour
{
    public Transform player;

    public float rotationSpeed = 90f;


    



    public void CheckPlayerInstance()
    {
        if (player == null)
        {
            //Find Player 
            GameObject go = GameObject.FindWithTag("Player");
            if (go != null)
            {
                player = go.transform;
            }
        }

        //makes player exist

        if (player == null)
        {
            return;
        }
    }
    

    public void EnemyFacesPlayer()
    {
        //faces the player 
        Vector3 dir = player.position - transform.position;
        dir.Normalize(); // sets it to a vector that has (-1,0,) 

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;   //will return a radian that is corred angle based on X and Y

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotationSpeed * Time.deltaTime);
    }
}
