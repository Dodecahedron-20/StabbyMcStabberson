using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{


    public GameObject ACube;
    public ParticleSystem Damage;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        DamagePlayer();
    }

   private void DamagePlayer()
    {
        ACube.SetActive(true);
        Damage.Play();
        GM.instance.LooseLife();
    }


}
