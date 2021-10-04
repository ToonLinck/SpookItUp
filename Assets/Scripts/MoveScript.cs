using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    Rigidbody2D rig;

    bool movable = true;
    float movespeed = 10f;
    float movex;
    
    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (movable)
        {
            rig.gravityScale = 0;
            movex = Input.GetAxisRaw("Horizontal") * movespeed * Time.deltaTime;
           
        } else
        {
            rig.gravityScale = 1;
        }
        if (gameObject.transform.position.x < -5.5f) { gameObject.transform.position = new Vector2(-5.5f, gameObject.transform.position.y); }
        if (gameObject.transform.position.x > 5.5f) { gameObject.transform.position = new Vector2(5.5f, gameObject.transform.position.y); }
    }


    private void FixedUpdate()
    {
        

        gameObject.transform.position = new Vector2(gameObject.transform.position.x + movex, gameObject.transform.position.y);
        movex = 0;
    }

    public void SetMovable(bool m)
    {

        movable = m;

    }

    public void SetPos(Vector2 vec)
    {

        gameObject.transform.position = vec;

    }

    public float GetRotation()
    {
        return rig.rotation;
    }

    public void SetRotation(float rot)
    {
        rig.rotation = rot;
    }

}
