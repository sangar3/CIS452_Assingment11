using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidCastle : MonoBehaviour
{
    public GameObject questboundary;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log(" player touch");
            questboundary.SetActive(true);


        }
    }
}
