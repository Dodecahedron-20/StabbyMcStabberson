using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private Vector3 playerPos = new Vector3(0, -3, 0);

    public float MoveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

        }

        float xPos = transform.position.x + (Input.GetAxisRaw("Horizontal") * MoveSpeed * Time.deltaTime);
        playerPos = new Vector3(Mathf.Clamp(xPos, -7.4f, 7.4f), -3f, 0f);
        transform.position = playerPos;




    }
}
