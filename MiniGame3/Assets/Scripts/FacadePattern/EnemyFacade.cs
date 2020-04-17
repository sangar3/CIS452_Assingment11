using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacade : MonoBehaviour
{

    public EnemyMove AImove;
    public EnemyDirection AIdirection;


    private void Awake()
    {
        AImove = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyMove>();

    }
    void Start()
    {
        AIFindsPlayer();
    }
    void Update()
    {
        AIchecksPlayerInstance();
        AIdirectionController();
        AIMovesToPlayer();

    }


    void AIFindsPlayer()
    {
        AImove.FindPlayer();
    }

    void AIMovesToPlayer()
    {
        AImove.MoveToPlayer();
    }

   void AIdirectionController()
   {
        AIdirection.EnemyFacesPlayer();

   }
   void AIchecksPlayerInstance()
    {
        AIdirection.CheckPlayerInstance();

    }

}
