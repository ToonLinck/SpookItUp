using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rig;
    BoxCollider2D coll;

    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();
        coll = gameObject.GetComponent<BoxCollider2D>();

        rig.rotation = Random.Range(0, 90);
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
