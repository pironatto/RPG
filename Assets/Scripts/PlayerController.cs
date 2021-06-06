using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    public float speed = 2;
    private Vector2 target;




    // Start is called before the first frame update
    void Start()
    {
       target = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0)) {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           
        }
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
    

}
