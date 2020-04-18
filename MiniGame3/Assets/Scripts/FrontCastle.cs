using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCastle : MonoBehaviour
{
    

    public GameObject tutorialtext;
   
    public GameObject monstertext;
    public AudioClip questcompleteSFX;




    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log(" player touch");
            tutorialtext.SetActive(false);
            AudioManager.Instance.PlaySFX(questcompleteSFX, 1f);
            monstertext.SetActive(true);
           
        }
    }
}
