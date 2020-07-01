using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public int HitPoints;

    public static int movespeed = 1;
    public Vector3 userDirection = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);

    }


    private void OnCollisionEnter(Collision collision)
    {
        
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
