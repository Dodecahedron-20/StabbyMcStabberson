using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public int HitPoints;


    

    // Start is called before the first frame update
    void Start()
    {
       
        //movement that doesn't work
        transform.position = new Vector3(6, -3, 0);

        Vector3 newPosition = transform.position;
        newPosition.y = 100;
        transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //more not-working movement things
        transform.position += new Vector3(1 * Time.deltaTime, 0, 0);

    }


    private void OnCollisionEnter(Collision collision)
    {
        
        {
            Destroy(gameObject);
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
      

    }






}
