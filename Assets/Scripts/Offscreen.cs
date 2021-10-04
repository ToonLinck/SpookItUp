using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offscreen : MonoBehaviour
{

    public GameObject controller;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        controller.GetComponent<Lives>().LivesDown();
        Destroy(collision.gameObject);
        controller.GetComponent<Lives>().RemovePoint();


    }
}
