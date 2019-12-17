using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Transform tf;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     void Update()
    { 


        if(System.Math.Floor(tf.position.y) < 3)
        {

            if(Input.GetKeyDown(KeyCode.Space))
            {

                transform.Translate(new Vector3(0, .4f, 0));

            }

        }


    }
}
