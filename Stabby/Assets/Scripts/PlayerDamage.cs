using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{


  
    public ParticleSystem Damage;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Mob")
        {
            DamagePlayer();
        }


    }




    private void DamagePlayer()
    {
       
        Damage.Play();
        GM.instance.LooseLife();
    }


}
