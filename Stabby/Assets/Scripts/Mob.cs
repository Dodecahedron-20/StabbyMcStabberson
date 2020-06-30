using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public int HitPoints;


    private Vector3 MobPos = new Vector3(7, -3, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        ReduceHitPoints();
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
