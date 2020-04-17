using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject fireball;
    
    public GameObject crosshair;
    Vector3 aim;
    Vector2 shootingDirection;
    public float spellspeed;
    public float spellDeathTimer;
    public float crosshairRange;

    void Update()
    {
        ProcessInputs();
        AimAndShoot();

    }



    private void ProcessInputs()
    {
        aim = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        aim.Normalize();
        shootingDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void AimAndShoot()
    {

        if (aim.magnitude > 0.0f)
        {


            shootingDirection.Normalize();
            crosshair.transform.localPosition = aim *= crosshairRange;
            crosshair.SetActive(true);
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject spell = Instantiate(fireball, transform.position, Quaternion.identity);
                spell.GetComponent<Rigidbody2D>().velocity = shootingDirection*spellspeed;
                spell.transform.Rotate(0.0f,0.0f,Mathf.Atan2(shootingDirection.y,shootingDirection.x) * Mathf.Rad2Deg);
                Destroy(spell, spellDeathTimer);



            }

        }
        else
        {
            crosshair.SetActive(false);
        }
    }
}
