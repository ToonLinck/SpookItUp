using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rig;
    CapsuleCollider2D coll;


    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();
        coll = gameObject.GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {



    }


    public void SetPos(Vector2 vec)
    {

        gameObject.transform.position = vec;

    }

}
