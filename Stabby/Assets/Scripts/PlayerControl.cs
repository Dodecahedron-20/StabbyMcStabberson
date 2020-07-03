using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public bool PausedMenuActive = false;
    private Rigidbody2D rb;

    public bool Move;

    //testing invokes shorter than 1

    private float endMove = 0.2f;

    //sword things go here

    public GameObject LeftSword;
    public GameObject RightSword;
    public GameObject Shield;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
      
        if(Time.timeScale == 0)
        {
            PausedMenuActive = true;

        }
        else
        {
            PausedMenuActive = false;
        }

        if (Move == false)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && PausedMenuActive == false)
            {
                Move = true;
                LeftSword.SetActive(true);
                Invoke("SwordLeftOff", endMove);

                transform.position += Vector3.left;

            }

            if (Input.GetKeyDown(KeyCode.RightArrow) && PausedMenuActive == false)
            {
                Move = true;
                RightSword.SetActive(true);
                Invoke("SwordRightOff", endMove);

                transform.position += Vector3.right;

                
            }


            if (Input.GetKeyDown(KeyCode.Space) && PausedMenuActive == false)
            {
                Move = true;
                Shield.SetActive(true);
                Invoke("ShieldOff", 1);



                LeftSword.SetActive(false);
                RightSword.SetActive(false);
            }


        }



    }


    private void SwordLeftOff()
    {
        LeftSword.SetActive(false);
        Move = false;


    }

    private void SwordRightOff()
    {
        RightSword.SetActive(false);
        Move = false;


    }

    private void ShieldOff()
    {
        Shield.SetActive(false);
        Move = false;


    }


    public void Death()
    {
        Destroy(gameObject);
    }


}
