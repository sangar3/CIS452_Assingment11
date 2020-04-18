using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EnemyTakeDamage : MonoBehaviour
{
    public int health;
    public Text Enemyhealth;
    public GameObject enemy;
    public GameObject facadeclient;
    public AudioClip enemyhurtSFX;
    void Start()
    {
        Enemyhealth.text = health.ToString();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Fireball")
        {
            Debug.Log("enemy hit by fireball");
            AITakeDamage();



        }
    }
    public void AITakeDamage()
    {
        AudioManager.Instance.PlaySFX(enemyhurtSFX, .3f);
        --health;
        Enemyhealth.text = health.ToString();

        if (health==0)
        {
            enemy.SetActive(false);
            facadeclient.SetActive(false);
            Debug.Log("you win");
            SceneManager.LoadScene("youwin");
        }
    }
}
