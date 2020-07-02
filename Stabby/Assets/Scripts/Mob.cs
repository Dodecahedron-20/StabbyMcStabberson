using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public int HitPoints;

    public float movespeed;
    public Vector2 userDirection = Vector2.right;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);

    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.name == "Sword")
        {
            ReduceHitPoints();
        }






    }

    private void ReduceHitPoints()
    {
        HitPoints--;
        if (HitPoints <= 0)
        {
            KillMob();
        }
    }

    public void KillMob()
    {
        Destroy(gameObject);

    }

}

   
