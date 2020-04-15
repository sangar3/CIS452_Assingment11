using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacade : MonoBehaviour
{
    public EnemyMove enemy;

    private void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyMove>();

    }
    void Start()
    {
       enemy.FindPlayer();
    }
    void Update()
    {
        enemy.MoveToPlayer();
    }
}
