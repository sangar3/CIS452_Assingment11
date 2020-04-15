using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public int Maxhealth = 3;
    public Text playerhealth;




    void Start()
    {
        playerhealth.text = Maxhealth.ToString();
    }



    void Update()
    {
        if (Maxhealth == 0)
        {
            GameOver();

        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "IceBall")
        {
            Debug.Log(" player hit by iceball");

            --Maxhealth;
            playerhealth.text = Maxhealth.ToString();
        }
    }

    public void GameOver()
    {
        Debug.Log("gameover");
        SceneManager.LoadScene("GameOver");
    }

}
