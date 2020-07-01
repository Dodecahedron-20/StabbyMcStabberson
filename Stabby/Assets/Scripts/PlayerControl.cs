using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public bool PausedMenuActive = false;


    //testing invokes shorter than 1

    private float endMove = 0.1f;

    //sword things go here

    public GameObject LeftSword;
    public GameObject RightSword;
    public GameObject Shield;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
      

        if (Input.GetKeyDown(KeyCode.LeftArrow) && PausedMenuActive == false)
        {
            LeftSword.SetActive(true);
            Invoke("SwordLeftOff", endMove);

            transform.position += Vector3.left;

            RightSword.SetActive(false);
            Shield.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && PausedMenuActive == false)
        {
            RightSword.SetActive(true);
            Invoke("SwordRightOff", endMove);

            transform.position += Vector3.right;

            LeftSword.SetActive(false);
            Shield.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && PausedMenuActive == false)
        {
            Shield.SetActive(true);
            Invoke("ShieldOff", 1);
            

            
            LeftSword.SetActive(false);
            RightSword.SetActive(false);
        }

        



    }


    private void SwordLeftOff()
    {
        LeftSword.SetActive(false);



    }

    private void SwordRightOff()
    {
        RightSword.SetActive(false);



    }

    private void ShieldOff()
    {
        Shield.SetActive(false);



    }



    public void Freeze()
    {
        PausedMenuActive = true;
    }



}
