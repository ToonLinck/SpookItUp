using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCorn : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rig;
    BoxCollider2D coll;

    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();
        coll = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }



}
